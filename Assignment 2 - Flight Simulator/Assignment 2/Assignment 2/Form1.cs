using System;
using System.Text;
using System.Threading;
using System.Net;
using System.Net.Sockets;
///using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Windows.Forms;




namespace Assignment_2
{

    public delegate void RecievedDataHandler(TelemetryUpdate telemetryUpdate);
    public delegate void SendingDataHandler(ControlsUpdate controlsUpdate);


    public struct ControlsUpdate
    {
        public double Throttle;//store the throttle value to pass to simulator
        public double ElevatorPitch;//store the elevator pitch value to pass to simulatr
    }

    public struct TelemetryUpdate
    {
        public double Altitude;//store altitude value passed from simulator
        public double Speed;//store speed value passed from simulator
        public double Distance;//store distance value passed from simulator
        public double Pitch;//store pitch value passed from simulator
        public double VerticalSpeed;//store vertical value passed from simulator

        public double Throttle;//store throttle value passed from simulator (this is for if throttle is updated on the simulator rather than the reciever)
        public double ElevatorPitch;//store elevator pitch value passed from simulator (this is for if pitch is updated on the simulator rather than the reciever)

        public int WarningCode;//store warning code value passed from simulator 
    }
    public partial class frmRemoteFlightController : Form
    {
        //DataReciever reciever = new DataReciever();
        DataSender Sender = new DataSender();
        TcpClient Client = new TcpClient();
        DataReciever reciever = new DataReciever();
        int Port;
        IPAddress IP;
        bool toDisconnect = false;




        public frmRemoteFlightController()
        {
            InitializeComponent();
            reciever.RecievingEvent += new RecievedDataHandler(getControlsUpdate);
            Sender.SendingEvent += new SendingDataHandler(setControlsUpdate);

        }
        public void ConnectOrDisonnect()
        {

            if (int.TryParse(txtPort.Text, out Port))//try to convert port.text to int and store
            { }
            else
            {
                MessageBox.Show("Invalid port number.");//error if it cannot
            }

            try//try to conntect to ip 
            {
                IP = IPAddress.Parse(txtIp.Text);//try to convert to IP address and if success continue 

                try//try to connect using entered port and IP
                {

                    Client.Connect(IP, Port);//connect passing user entered port and IP
                    lblCurrentConnection.Visible = true;//allow user to see the current connection ip
                    lblCurrentConnection.Text = " Connected to: " + IP.ToString();
                    trkThrottle.Enabled = true;
                    trkElevator.Enabled = true;
                    btnConnect.Enabled = false;//stop user from pressing connect as they are already connected
                    btnDisconnect.Enabled = true;


                    Thread retrivingThread = new Thread(new ThreadStart(reciever.RetriveData));
                    retrivingThread.Start();//thread starts immediatly after connection
                    NetworkStream stream = Client.GetStream();
                    DataReciever.stream = stream;//calls stream function and passes stream into it
                }
                catch (Exception error)//this will catch the error message returned from the IPAddress class
                {
                    MessageBox.Show(error.Message);//outputs compiler error message for user
                    txtIp.Focus();//set focus to the ip address

                }
            }
            catch//catch if the ip address is invalid
            {
                MessageBox.Show("Invalid IP address."); //error message if fail
                txtIp.Text = "";//resets textbox
            }



        }
        public void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectOrDisonnect();
        }
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            toDisconnect = true;
            ConnectOrDisonnect();
        }

        private void trkElevator_ValueChanged(object sender, EventArgs e)
        {
            lblCurrentThrottle.Text = trkThrottle.Value.ToString() + ".0%";//update label on the throttle control for new throttle value           
            ControlsScrollUpdate();//send off control update to be made
        }

        private void trkElevator_Scroll(object sender, EventArgs e)
        {
            // double elevatorValue = (trkElevator.Value * 0.1) / trkElevator.TickFrequency;//sets the elevatorValue that will be sent to the elevator value of the trackbar
            lblCurrentElevator.Text = trkElevator.Value.ToString() + ".0%";//updates the label on the control
            ControlsScrollUpdate();//send instructions to simulator
        }
        private void trkThrottle_Scroll(object sender, EventArgs e)
        {
            lblCurrentThrottle.Text = trkThrottle.Value.ToString() + "%";//updates the label on the control
            ControlsScrollUpdate();//send instructions to simulator
        }

        private void trkThrottle_MouseEnter(object sender, EventArgs e)//Called when mouse is over trkThrottle
        {
            ttThrottle.Show("Use these controls to send instructions to increase or decrease the throttle on the flight simulator.", trkThrottle, 0, 0, 3000);//message to the user explaining how to use the slider
        }

        private void trkElevator_MouseEnter(object sender, EventArgs e)//Called when mouse is over trkElevator
        {
            ttElevator.Show("Use these controls to send instructions to increase or decrease the pitch on the flight simulator.", trkElevator, 0, 0, 3000);//message to the user explaining how to use the slider
        }
        private void trkThrottle_MouseLeave(object sender, EventArgs e)//called when mouse leaves trkThrottle 
        {
            ttThrottle.Hide(trkThrottle);//hide message to the user
        }

        private void trkElevator_MouseLeave(object sender, EventArgs e)//called when mouse leaves trkElevator 
        {
            ttElevator.Hide(trkElevator);//hide message to the user
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//closes the open form
        }

        private void dgvLiveUpdates_MouseEnter(object sender, EventArgs e)//calls when data grid is moused over
        {
            ttLiveUpdates.Show("Here shows a live telemetry update in table form to be able to better view changes in the controls.", grpLiveUpdates, 0, 0, 3000);//message to the user exlaining what data grid is
        }

        private void dgvLiveUpdates_MouseLeave(object sender, EventArgs e)//called when mouse leaves data grid
        {
            ttLiveUpdates.Hide(dgvLiveUpdates);//hide message
        }

        private void btnConnect_MouseEnter(object sender, EventArgs e)//when mouse is over the connect button
        {
            ttConnect.Show("Before accessing any controls you need to enter the IP address\n and port of simulator you are connecting to.", lblCurrentConnection, 0, 0, 3000);//message to the user explaining what to type in textboxes
        }

        private void btnConnect_MouseLeave(object sender, EventArgs e)//when mouse leaves the connect button
        {
            ttConnect.Hide(lblCurrentConnection);//hide message
        }

        public void ControlsScrollUpdate()
        {

            NetworkStream stream = Client.GetStream();//new stream to send instructions

            ControlsUpdate controlsUpdate = new ControlsUpdate();//generate a new set of controls to send off to the simulator


            controlsUpdate.Throttle = trkThrottle.Value;//setting the new throttle control instructions to the trackbar value
            controlsUpdate.ElevatorPitch = trkElevator.Value * 0.1;//setting the new pitch control instructions to the trackbar value

            Sender.stream = stream;
            Sender.SendData(controlsUpdate);//pass controlsUpdate object to SendData function to be sent off to the simulator

            Thread.Sleep(0100);
        }

        public class DataReciever
        {
            public event RecievedDataHandler RecievingEvent;//invoke delegate for recieving data from simulator
            public static NetworkStream stream;

            private bool StartRetrieving = false;//create bool to be able to turn the reciever on and off

            public void RetriveData()//function to recieve the data from the simulator
            {

                TelemetryUpdate telemetryUpdate = new TelemetryUpdate();//new set of telemerty variables

                StartRetrieving = true;//when function is called startrecieving is turned on

                while (StartRetrieving)//while startRecieving is on
                {
                    byte[] buffer = new byte[256];//create buffer to write data into
                    try//try to decode data
                    {
                        int num_bytes = stream.Read(buffer, 0, 256);//sets number of bytes recieved to num_bytess setting a minumum and a maximum
                        string dataToRecieve = Encoding.ASCII.GetString(buffer, 0, num_bytes);//decode data and save to string dataToRecieve
                        telemetryUpdate = JsonConvert.DeserializeObject<TelemetryUpdate>(dataToRecieve);//convert from json and set to telemerty updates
                    }
                    catch { }//if cannot decode data
                    RecievingEvent?.Invoke(telemetryUpdate);//invoke new telemetry updates

                }
            }
        }
        public class DataSender
        {
            public event SendingDataHandler SendingEvent;
            public NetworkStream stream;

            public void SendData(ControlsUpdate controlUpdate)//function called to encode data to be sent to simulator
            {
                string dataToSend;//string to hold data being sent
                dataToSend = JsonConvert.SerializeObject(controlUpdate);//converting the control instructions to json and storing it in dataToSend

                byte[] rawData = Encoding.ASCII.GetBytes(dataToSend);//converts string to bytes passing in string to get bytes function
                stream.Write(rawData, 0, rawData.Length);// write to stream (ASCII data, starting at inex 0, ending at last index.)

                SendingEvent?.Invoke(controlUpdate);//invokes a new sending event with instance of controls update
            }
        }

        private void setControlsUpdate(ControlsUpdate controlUpdate)//called to set new control instructions to send to the simulator
        {

            if (this.InvokeRequired)//if invoke is required
            {
                this.Invoke(new SendingDataHandler(setControlsUpdate), new object[] { controlUpdate });//invokes a new sending event with instance of setcontrolsupdate
            }
            else
            {
                controlUpdate.Throttle = trkThrottle.Value;//set throttle control to value of throttle trackbar
                controlUpdate.ElevatorPitch = trkElevator.Value * 0.1;//set pitch control to value of pitch trackbar
            }
        }
        private void getControlsUpdate(TelemetryUpdate telemetryUpdate)
        {
            if (this.InvokeRequired)//if invoke is needed 
            {
                this.Invoke(new RecievedDataHandler(getControlsUpdate), new object[] { telemetryUpdate });//involkes new instance of getControlsUpdate
            }
            else
            {
                lblAltitude.Text = Math.Round(telemetryUpdate.Altitude).ToString() + " ft";//sets label for the current altitude while rounding it and adding measurement
                lblAirspeed.Text = Math.Round(telemetryUpdate.Speed).ToString() + " Knts";//sets label for the current speed while rounding it and adding measurement
                lblVerticalSpeed.Text = Math.Round(telemetryUpdate.VerticalSpeed).ToString() + " Fpm";//sets label for the current vertical speed while rounding it and adding measurement
                lblThrottle.Text = telemetryUpdate.Throttle.ToString() + "%";////sets label for the current throttle (from the simulator not reciever)
                lblPitchAngle.Text = Math.Round(telemetryUpdate.Pitch).ToString() + "°";//sets label for the current pitch angle of the plane 
                lblElevatorPitch.Text = telemetryUpdate.ElevatorPitch.ToString() + "°";//sets label for the current elevator pitch from the controls (from the simulator not reciever)

                lblDateAndTime.Text = DateTime.Now.ToString();//display updating date and time to the user
                DataGridViewRow row = (DataGridViewRow)dgvLiveUpdates.Rows[0].Clone();
                row.Cells[0].Value = telemetryUpdate.Speed.ToString();//Setting cell to value of current speed
                row.Cells[1].Value = telemetryUpdate.VerticalSpeed.ToString();//setting cell to value of current vertical speed
                row.Cells[2].Value = "000";
                row.Cells[3].Value = telemetryUpdate.Pitch.ToString();//setting cell to value of the planes current pitch
                row.Cells[4].Value = telemetryUpdate.Altitude.ToString();//setting cell to the value of the current altitude
                row.Cells[5].Value = telemetryUpdate.Throttle.ToString();//setting cell to value of the current throttle control    
                row.Cells[6].Value = telemetryUpdate.ElevatorPitch.ToString();//setting cell to value of the current elevator pitch control
                row.Cells[7].Value = telemetryUpdate.WarningCode.ToString();//setting cell to the value of the current warning code

                lblCurrentThrottle.Text = telemetryUpdate.Throttle.ToString() + ".0 %";//setting the label on the throttle control to the current throttle (this is only needed for if controls are changed on the simulator)
                lblCurrentElevator.Text = telemetryUpdate.ElevatorPitch.ToString() + "°";//setting the label on the pitch control to the current throttle (this is only needed for if controls are changed on the simulator)

                trkThrottle.Value = Convert.ToInt32(telemetryUpdate.Throttle);//setting the value of throttle control to the current throttle (this is only needed for if controls are changed on the simulator)
                trkElevator.Value = Convert.ToInt32(telemetryUpdate.ElevatorPitch * 10);//setting the value of pitch control to the current elevator pitch (this is only needed for if controls are changed on the simulator)


                dgvLiveUpdates.Rows.Insert(0, row);//add new row at top of data grid

                if (dgvLiveUpdates.Rows.Count > 10)//if datagrid has 10 entries
                {
                    dgvLiveUpdates.Rows.RemoveAt(9);//remove last one
                }

                if (telemetryUpdate.WarningCode == 1)//if warning code 1 is returned
                {
                    this.lblWarning.ForeColor = System.Drawing.Color.Red;//update text colour to be red indicating a warning
                    lblWarning.Text = "Warning: Too low terrain";//apply warning string to label
                }
                else if (telemetryUpdate.WarningCode == 2)//if warning code 2 is returned
                {
                    this.lblWarning.ForeColor = System.Drawing.Color.Red;//update text colour to be red indicating a warning
                    lblWarning.Text = "Warning: Stall risk";//apply warning string to label
                }
                else//if no warning code is returned
                {
                    this.lblWarning.ForeColor = System.Drawing.Color.Green;//sets colour to be green indicating all is okay
                    lblWarning.Text = "No warning";//update text to display "No Warning"
                }
            }
        }


    }
}

