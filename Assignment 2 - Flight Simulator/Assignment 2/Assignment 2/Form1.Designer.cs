namespace Assignment_2
{
    partial class frmRemoteFlightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoteFlightController));
            this.lbltitle = new System.Windows.Forms.Label();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.lblCurrentConnection = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.dgvLiveUpdates = new System.Windows.Forms.DataGridView();
            this.clmSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVerticalSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPitchAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAltitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmThrottle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmElevatorPitch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmWarningCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLiveUpdates = new System.Windows.Forms.GroupBox();
            this.grpAutopilot = new System.Windows.Forms.GroupBox();
            this.lblDistanceRemaining = new System.Windows.Forms.Label();
            this.lblDistanceRemainingLabel = new System.Windows.Forms.Label();
            this.lblAutopilotDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnLand = new System.Windows.Forms.Button();
            this.btnTakeOff = new System.Windows.Forms.Button();
            this.grpPlane = new System.Windows.Forms.GroupBox();
            this.lblElevatorPitch = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.lblVerticalSpeed = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblThrottle = new System.Windows.Forms.Label();
            this.lblPitchAngle = new System.Windows.Forms.Label();
            this.lblAirspeed = new System.Windows.Forms.Label();
            this.lblElevatorPitchLabel = new System.Windows.Forms.Label();
            this.lblAltitudeLabel = new System.Windows.Forms.Label();
            this.lblVerticalSpeedLabel = new System.Windows.Forms.Label();
            this.lblDistanceLabel = new System.Windows.Forms.Label();
            this.lblThrottleLabel = new System.Windows.Forms.Label();
            this.lblPitchAngleLabel = new System.Windows.Forms.Label();
            this.lblAirspeedLabel = new System.Windows.Forms.Label();
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCurrentElevator = new System.Windows.Forms.Label();
            this.grpCurrentThrottle = new System.Windows.Forms.GroupBox();
            this.lblCurrentThrottle = new System.Windows.Forms.Label();
            this.lblMinElevator = new System.Windows.Forms.Label();
            this.lblMinThrottle = new System.Windows.Forms.Label();
            this.lblMaxElevator = new System.Windows.Forms.Label();
            this.lblMaxThrottle = new System.Windows.Forms.Label();
            this.lblElevatorPitchControlLabel = new System.Windows.Forms.Label();
            this.lblThrottleControlLabel = new System.Windows.Forms.Label();
            this.trkThrottle = new System.Windows.Forms.TrackBar();
            this.trkElevator = new System.Windows.Forms.TrackBar();
            this.grpWarning = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.ttThrottle = new System.Windows.Forms.ToolTip(this.components);
            this.ttElevator = new System.Windows.Forms.ToolTip(this.components);
            this.ttLiveUpdates = new System.Windows.Forms.ToolTip(this.components);
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.ttConnect = new System.Windows.Forms.ToolTip(this.components);
            this.grpConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveUpdates)).BeginInit();
            this.grpLiveUpdates.SuspendLayout();
            this.grpAutopilot.SuspendLayout();
            this.grpPlane.SuspendLayout();
            this.grpControls.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCurrentThrottle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevator)).BeginInit();
            this.grpWarning.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(31, 17);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(308, 31);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Remote Flight Controller";
            // 
            // grpConnection
            // 
            this.grpConnection.Controls.Add(this.btnDisconnect);
            this.grpConnection.Controls.Add(this.lblCurrentConnection);
            this.grpConnection.Controls.Add(this.btnConnect);
            this.grpConnection.Controls.Add(this.lblPort);
            this.grpConnection.Controls.Add(this.lblIp);
            this.grpConnection.Controls.Add(this.txtPort);
            this.grpConnection.Controls.Add(this.txtIp);
            this.grpConnection.Location = new System.Drawing.Point(37, 415);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(275, 153);
            this.grpConnection.TabIndex = 1;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection Details";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(144, 109);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 23);
            this.btnDisconnect.TabIndex = 5;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblCurrentConnection
            // 
            this.lblCurrentConnection.AutoSize = true;
            this.lblCurrentConnection.Location = new System.Drawing.Point(22, 26);
            this.lblCurrentConnection.Name = "lblCurrentConnection";
            this.lblCurrentConnection.Size = new System.Drawing.Size(77, 13);
            this.lblCurrentConnection.TabIndex = 4;
            this.lblCurrentConnection.Text = "Connected to: ";
            this.lblCurrentConnection.Visible = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(25, 109);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnConnect.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(22, 91);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Port";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Location = new System.Drawing.Point(19, 64);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(87, 13);
            this.lblIp.TabIndex = 2;
            this.lblIp.Text = "Local IP Address";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(112, 83);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(112, 57);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(100, 20);
            this.txtIp.TabIndex = 0;
            // 
            // dgvLiveUpdates
            // 
            this.dgvLiveUpdates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiveUpdates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSpeed,
            this.clmVerticalSpeed,
            this.clmDistance,
            this.clmPitchAngle,
            this.clmAltitude,
            this.clmThrottle,
            this.clmElevatorPitch,
            this.clmWarningCode});
            this.dgvLiveUpdates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLiveUpdates.Location = new System.Drawing.Point(3, 16);
            this.dgvLiveUpdates.Name = "dgvLiveUpdates";
            this.dgvLiveUpdates.Size = new System.Drawing.Size(688, 280);
            this.dgvLiveUpdates.TabIndex = 2;
            this.dgvLiveUpdates.MouseEnter += new System.EventHandler(this.dgvLiveUpdates_MouseEnter);
            this.dgvLiveUpdates.MouseLeave += new System.EventHandler(this.dgvLiveUpdates_MouseLeave);
            // 
            // clmSpeed
            // 
            this.clmSpeed.HeaderText = "Speed";
            this.clmSpeed.Name = "clmSpeed";
            this.clmSpeed.ReadOnly = true;
            this.clmSpeed.Width = 80;
            // 
            // clmVerticalSpeed
            // 
            this.clmVerticalSpeed.HeaderText = "Vertical Speed";
            this.clmVerticalSpeed.Name = "clmVerticalSpeed";
            this.clmVerticalSpeed.ReadOnly = true;
            this.clmVerticalSpeed.Width = 80;
            // 
            // clmDistance
            // 
            this.clmDistance.HeaderText = "Distance";
            this.clmDistance.Name = "clmDistance";
            this.clmDistance.ReadOnly = true;
            this.clmDistance.Width = 80;
            // 
            // clmPitchAngle
            // 
            this.clmPitchAngle.HeaderText = "Pitch Angle";
            this.clmPitchAngle.Name = "clmPitchAngle";
            this.clmPitchAngle.ReadOnly = true;
            this.clmPitchAngle.Width = 80;
            // 
            // clmAltitude
            // 
            this.clmAltitude.HeaderText = "Altitude";
            this.clmAltitude.Name = "clmAltitude";
            this.clmAltitude.ReadOnly = true;
            this.clmAltitude.Width = 80;
            // 
            // clmThrottle
            // 
            this.clmThrottle.HeaderText = "Throttle";
            this.clmThrottle.Name = "clmThrottle";
            this.clmThrottle.ReadOnly = true;
            this.clmThrottle.Width = 80;
            // 
            // clmElevatorPitch
            // 
            this.clmElevatorPitch.HeaderText = "Elevator Pitch";
            this.clmElevatorPitch.Name = "clmElevatorPitch";
            this.clmElevatorPitch.ReadOnly = true;
            this.clmElevatorPitch.Width = 80;
            // 
            // clmWarningCode
            // 
            this.clmWarningCode.HeaderText = "Warning Code";
            this.clmWarningCode.Name = "clmWarningCode";
            this.clmWarningCode.ReadOnly = true;
            this.clmWarningCode.Width = 80;
            // 
            // grpLiveUpdates
            // 
            this.grpLiveUpdates.Controls.Add(this.dgvLiveUpdates);
            this.grpLiveUpdates.Location = new System.Drawing.Point(37, 74);
            this.grpLiveUpdates.Name = "grpLiveUpdates";
            this.grpLiveUpdates.Size = new System.Drawing.Size(694, 299);
            this.grpLiveUpdates.TabIndex = 3;
            this.grpLiveUpdates.TabStop = false;
            this.grpLiveUpdates.Text = "Live Updates";
            // 
            // grpAutopilot
            // 
            this.grpAutopilot.Controls.Add(this.lblDistanceRemaining);
            this.grpAutopilot.Controls.Add(this.lblDistanceRemainingLabel);
            this.grpAutopilot.Controls.Add(this.lblAutopilotDesc);
            this.grpAutopilot.Controls.Add(this.textBox1);
            this.grpAutopilot.Controls.Add(this.btnLand);
            this.grpAutopilot.Controls.Add(this.btnTakeOff);
            this.grpAutopilot.Location = new System.Drawing.Point(37, 579);
            this.grpAutopilot.Name = "grpAutopilot";
            this.grpAutopilot.Size = new System.Drawing.Size(275, 123);
            this.grpAutopilot.TabIndex = 4;
            this.grpAutopilot.TabStop = false;
            this.grpAutopilot.Text = "Autopilot";
            // 
            // lblDistanceRemaining
            // 
            this.lblDistanceRemaining.AutoSize = true;
            this.lblDistanceRemaining.Location = new System.Drawing.Point(153, 98);
            this.lblDistanceRemaining.Name = "lblDistanceRemaining";
            this.lblDistanceRemaining.Size = new System.Drawing.Size(42, 13);
            this.lblDistanceRemaining.TabIndex = 5;
            this.lblDistanceRemaining.Text = "BLANK";
            this.lblDistanceRemaining.Visible = false;
            // 
            // lblDistanceRemainingLabel
            // 
            this.lblDistanceRemainingLabel.AutoSize = true;
            this.lblDistanceRemainingLabel.Location = new System.Drawing.Point(6, 98);
            this.lblDistanceRemainingLabel.Name = "lblDistanceRemainingLabel";
            this.lblDistanceRemainingLabel.Size = new System.Drawing.Size(103, 13);
            this.lblDistanceRemainingLabel.TabIndex = 4;
            this.lblDistanceRemainingLabel.Text = "Distance Remaning:";
            this.lblDistanceRemainingLabel.Visible = false;
            // 
            // lblAutopilotDesc
            // 
            this.lblAutopilotDesc.AutoSize = true;
            this.lblAutopilotDesc.Location = new System.Drawing.Point(3, 22);
            this.lblAutopilotDesc.Name = "lblAutopilotDesc";
            this.lblAutopilotDesc.Size = new System.Drawing.Size(215, 26);
            this.lblAutopilotDesc.TabIndex = 3;
            this.lblAutopilotDesc.Text = "Please enter a distance to travel\r\n in NM (Nautical Mile) and press \"Take Off\".\r\n" +
    "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnLand
            // 
            this.btnLand.Enabled = false;
            this.btnLand.Location = new System.Drawing.Point(194, 59);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(75, 23);
            this.btnLand.TabIndex = 1;
            this.btnLand.Text = "Land";
            this.btnLand.UseVisualStyleBackColor = true;
            // 
            // btnTakeOff
            // 
            this.btnTakeOff.Location = new System.Drawing.Point(112, 59);
            this.btnTakeOff.Name = "btnTakeOff";
            this.btnTakeOff.Size = new System.Drawing.Size(75, 23);
            this.btnTakeOff.TabIndex = 0;
            this.btnTakeOff.Text = "Take Off";
            this.btnTakeOff.UseVisualStyleBackColor = true;
            // 
            // grpPlane
            // 
            this.grpPlane.Controls.Add(this.lblElevatorPitch);
            this.grpPlane.Controls.Add(this.lblAltitude);
            this.grpPlane.Controls.Add(this.lblVerticalSpeed);
            this.grpPlane.Controls.Add(this.lblDistance);
            this.grpPlane.Controls.Add(this.lblThrottle);
            this.grpPlane.Controls.Add(this.lblPitchAngle);
            this.grpPlane.Controls.Add(this.lblAirspeed);
            this.grpPlane.Controls.Add(this.lblElevatorPitchLabel);
            this.grpPlane.Controls.Add(this.lblAltitudeLabel);
            this.grpPlane.Controls.Add(this.lblVerticalSpeedLabel);
            this.grpPlane.Controls.Add(this.lblDistanceLabel);
            this.grpPlane.Controls.Add(this.lblThrottleLabel);
            this.grpPlane.Controls.Add(this.lblPitchAngleLabel);
            this.grpPlane.Controls.Add(this.lblAirspeedLabel);
            this.grpPlane.Location = new System.Drawing.Point(758, 90);
            this.grpPlane.Name = "grpPlane";
            this.grpPlane.Size = new System.Drawing.Size(189, 165);
            this.grpPlane.TabIndex = 5;
            this.grpPlane.TabStop = false;
            this.grpPlane.Text = "Plane";
            // 
            // lblElevatorPitch
            // 
            this.lblElevatorPitch.AutoSize = true;
            this.lblElevatorPitch.Location = new System.Drawing.Point(103, 116);
            this.lblElevatorPitch.Name = "lblElevatorPitch";
            this.lblElevatorPitch.Size = new System.Drawing.Size(0, 13);
            this.lblElevatorPitch.TabIndex = 13;
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Location = new System.Drawing.Point(103, 103);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(0, 13);
            this.lblAltitude.TabIndex = 12;
            // 
            // lblVerticalSpeed
            // 
            this.lblVerticalSpeed.AutoSize = true;
            this.lblVerticalSpeed.Location = new System.Drawing.Point(103, 90);
            this.lblVerticalSpeed.Name = "lblVerticalSpeed";
            this.lblVerticalSpeed.Size = new System.Drawing.Size(0, 13);
            this.lblVerticalSpeed.TabIndex = 11;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(103, 77);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(0, 13);
            this.lblDistance.TabIndex = 10;
            // 
            // lblThrottle
            // 
            this.lblThrottle.AutoSize = true;
            this.lblThrottle.Location = new System.Drawing.Point(103, 64);
            this.lblThrottle.Name = "lblThrottle";
            this.lblThrottle.Size = new System.Drawing.Size(0, 13);
            this.lblThrottle.TabIndex = 9;
            // 
            // lblPitchAngle
            // 
            this.lblPitchAngle.AutoSize = true;
            this.lblPitchAngle.Location = new System.Drawing.Point(103, 49);
            this.lblPitchAngle.Name = "lblPitchAngle";
            this.lblPitchAngle.Size = new System.Drawing.Size(0, 13);
            this.lblPitchAngle.TabIndex = 8;
            // 
            // lblAirspeed
            // 
            this.lblAirspeed.AutoSize = true;
            this.lblAirspeed.Location = new System.Drawing.Point(103, 36);
            this.lblAirspeed.Name = "lblAirspeed";
            this.lblAirspeed.Size = new System.Drawing.Size(0, 13);
            this.lblAirspeed.TabIndex = 7;
            // 
            // lblElevatorPitchLabel
            // 
            this.lblElevatorPitchLabel.AutoSize = true;
            this.lblElevatorPitchLabel.Location = new System.Drawing.Point(12, 116);
            this.lblElevatorPitchLabel.Name = "lblElevatorPitchLabel";
            this.lblElevatorPitchLabel.Size = new System.Drawing.Size(75, 13);
            this.lblElevatorPitchLabel.TabIndex = 6;
            this.lblElevatorPitchLabel.Text = "Elevator pitch:";
            // 
            // lblAltitudeLabel
            // 
            this.lblAltitudeLabel.AutoSize = true;
            this.lblAltitudeLabel.Location = new System.Drawing.Point(42, 103);
            this.lblAltitudeLabel.Name = "lblAltitudeLabel";
            this.lblAltitudeLabel.Size = new System.Drawing.Size(45, 13);
            this.lblAltitudeLabel.TabIndex = 5;
            this.lblAltitudeLabel.Text = "Altitude:";
            // 
            // lblVerticalSpeedLabel
            // 
            this.lblVerticalSpeedLabel.AutoSize = true;
            this.lblVerticalSpeedLabel.Location = new System.Drawing.Point(10, 90);
            this.lblVerticalSpeedLabel.Name = "lblVerticalSpeedLabel";
            this.lblVerticalSpeedLabel.Size = new System.Drawing.Size(77, 13);
            this.lblVerticalSpeedLabel.TabIndex = 4;
            this.lblVerticalSpeedLabel.Text = "Vertical speed:";
            // 
            // lblDistanceLabel
            // 
            this.lblDistanceLabel.AutoSize = true;
            this.lblDistanceLabel.Location = new System.Drawing.Point(35, 77);
            this.lblDistanceLabel.Name = "lblDistanceLabel";
            this.lblDistanceLabel.Size = new System.Drawing.Size(52, 13);
            this.lblDistanceLabel.TabIndex = 3;
            this.lblDistanceLabel.Text = "Distance:";
            // 
            // lblThrottleLabel
            // 
            this.lblThrottleLabel.AutoSize = true;
            this.lblThrottleLabel.Location = new System.Drawing.Point(41, 64);
            this.lblThrottleLabel.Name = "lblThrottleLabel";
            this.lblThrottleLabel.Size = new System.Drawing.Size(46, 13);
            this.lblThrottleLabel.TabIndex = 2;
            this.lblThrottleLabel.Text = "Throttle:";
            // 
            // lblPitchAngleLabel
            // 
            this.lblPitchAngleLabel.AutoSize = true;
            this.lblPitchAngleLabel.Location = new System.Drawing.Point(24, 49);
            this.lblPitchAngleLabel.Name = "lblPitchAngleLabel";
            this.lblPitchAngleLabel.Size = new System.Drawing.Size(63, 13);
            this.lblPitchAngleLabel.TabIndex = 1;
            this.lblPitchAngleLabel.Text = "Pitch angle:";
            // 
            // lblAirspeedLabel
            // 
            this.lblAirspeedLabel.AutoSize = true;
            this.lblAirspeedLabel.Location = new System.Drawing.Point(36, 36);
            this.lblAirspeedLabel.Name = "lblAirspeedLabel";
            this.lblAirspeedLabel.Size = new System.Drawing.Size(51, 13);
            this.lblAirspeedLabel.TabIndex = 0;
            this.lblAirspeedLabel.Text = "Airspeed:";
            // 
            // grpControls
            // 
            this.grpControls.Controls.Add(this.groupBox1);
            this.grpControls.Controls.Add(this.grpCurrentThrottle);
            this.grpControls.Controls.Add(this.lblMinElevator);
            this.grpControls.Controls.Add(this.lblMinThrottle);
            this.grpControls.Controls.Add(this.lblMaxElevator);
            this.grpControls.Controls.Add(this.lblMaxThrottle);
            this.grpControls.Controls.Add(this.lblElevatorPitchControlLabel);
            this.grpControls.Controls.Add(this.lblThrottleControlLabel);
            this.grpControls.Controls.Add(this.trkThrottle);
            this.grpControls.Controls.Add(this.trkElevator);
            this.grpControls.Location = new System.Drawing.Point(329, 415);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(412, 287);
            this.grpControls.TabIndex = 6;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controls";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCurrentElevator);
            this.groupBox1.Location = new System.Drawing.Point(235, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(60, 51);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current";
            // 
            // lblCurrentElevator
            // 
            this.lblCurrentElevator.AutoSize = true;
            this.lblCurrentElevator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentElevator.Location = new System.Drawing.Point(0, 15);
            this.lblCurrentElevator.Name = "lblCurrentElevator";
            this.lblCurrentElevator.Size = new System.Drawing.Size(49, 20);
            this.lblCurrentElevator.TabIndex = 1;
            this.lblCurrentElevator.Text = "0.0%";
            // 
            // grpCurrentThrottle
            // 
            this.grpCurrentThrottle.Controls.Add(this.lblCurrentThrottle);
            this.grpCurrentThrottle.Location = new System.Drawing.Point(22, 131);
            this.grpCurrentThrottle.Name = "grpCurrentThrottle";
            this.grpCurrentThrottle.Size = new System.Drawing.Size(63, 51);
            this.grpCurrentThrottle.TabIndex = 15;
            this.grpCurrentThrottle.TabStop = false;
            this.grpCurrentThrottle.Text = "Current";
            // 
            // lblCurrentThrottle
            // 
            this.lblCurrentThrottle.AutoSize = true;
            this.lblCurrentThrottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentThrottle.Location = new System.Drawing.Point(-2, 16);
            this.lblCurrentThrottle.Name = "lblCurrentThrottle";
            this.lblCurrentThrottle.Size = new System.Drawing.Size(49, 20);
            this.lblCurrentThrottle.TabIndex = 0;
            this.lblCurrentThrottle.Text = "0.0%";
            // 
            // lblMinElevator
            // 
            this.lblMinElevator.AutoSize = true;
            this.lblMinElevator.Location = new System.Drawing.Point(250, 252);
            this.lblMinElevator.Name = "lblMinElevator";
            this.lblMinElevator.Size = new System.Drawing.Size(48, 13);
            this.lblMinElevator.TabIndex = 14;
            this.lblMinElevator.Text = "Min: -5.0";
            // 
            // lblMinThrottle
            // 
            this.lblMinThrottle.AutoSize = true;
            this.lblMinThrottle.Location = new System.Drawing.Point(40, 252);
            this.lblMinThrottle.Name = "lblMinThrottle";
            this.lblMinThrottle.Size = new System.Drawing.Size(45, 13);
            this.lblMinThrottle.TabIndex = 13;
            this.lblMinThrottle.Text = "Min: 0.0";
            // 
            // lblMaxElevator
            // 
            this.lblMaxElevator.AutoSize = true;
            this.lblMaxElevator.Location = new System.Drawing.Point(250, 44);
            this.lblMaxElevator.Name = "lblMaxElevator";
            this.lblMaxElevator.Size = new System.Drawing.Size(48, 13);
            this.lblMaxElevator.TabIndex = 12;
            this.lblMaxElevator.Text = "Max: 5.0";
            // 
            // lblMaxThrottle
            // 
            this.lblMaxThrottle.AutoSize = true;
            this.lblMaxThrottle.Location = new System.Drawing.Point(25, 44);
            this.lblMaxThrottle.Name = "lblMaxThrottle";
            this.lblMaxThrottle.Size = new System.Drawing.Size(60, 13);
            this.lblMaxThrottle.TabIndex = 11;
            this.lblMaxThrottle.Text = "Max: 100.0";
            // 
            // lblElevatorPitchControlLabel
            // 
            this.lblElevatorPitchControlLabel.AutoSize = true;
            this.lblElevatorPitchControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevatorPitchControlLabel.Location = new System.Drawing.Point(258, 16);
            this.lblElevatorPitchControlLabel.Name = "lblElevatorPitchControlLabel";
            this.lblElevatorPitchControlLabel.Size = new System.Drawing.Size(106, 20);
            this.lblElevatorPitchControlLabel.TabIndex = 10;
            this.lblElevatorPitchControlLabel.Text = "Elevator Pitch";
            // 
            // lblThrottleControlLabel
            // 
            this.lblThrottleControlLabel.AutoSize = true;
            this.lblThrottleControlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrottleControlLabel.Location = new System.Drawing.Point(73, 21);
            this.lblThrottleControlLabel.Name = "lblThrottleControlLabel";
            this.lblThrottleControlLabel.Size = new System.Drawing.Size(63, 20);
            this.lblThrottleControlLabel.TabIndex = 9;
            this.lblThrottleControlLabel.Text = "Throttle";
            // 
            // trkThrottle
            // 
            this.trkThrottle.Enabled = false;
            this.trkThrottle.Location = new System.Drawing.Point(91, 44);
            this.trkThrottle.Maximum = 100;
            this.trkThrottle.Name = "trkThrottle";
            this.trkThrottle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkThrottle.Size = new System.Drawing.Size(45, 233);
            this.trkThrottle.TabIndex = 8;
            this.trkThrottle.Scroll += new System.EventHandler(this.trkThrottle_Scroll);
            this.trkThrottle.MouseEnter += new System.EventHandler(this.trkThrottle_MouseEnter);
            this.trkThrottle.MouseLeave += new System.EventHandler(this.trkThrottle_MouseLeave);
            // 
            // trkElevator
            // 
            this.trkElevator.Enabled = false;
            this.trkElevator.Location = new System.Drawing.Point(304, 44);
            this.trkElevator.Maximum = 50;
            this.trkElevator.Minimum = -50;
            this.trkElevator.Name = "trkElevator";
            this.trkElevator.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trkElevator.Size = new System.Drawing.Size(45, 233);
            this.trkElevator.TabIndex = 2;
            this.trkElevator.Scroll += new System.EventHandler(this.trkElevator_Scroll);
            this.trkElevator.ValueChanged += new System.EventHandler(this.trkElevator_ValueChanged);
            this.trkElevator.MouseEnter += new System.EventHandler(this.trkElevator_MouseEnter);
            this.trkElevator.MouseLeave += new System.EventHandler(this.trkElevator_MouseLeave);
            // 
            // grpWarning
            // 
            this.grpWarning.Controls.Add(this.lblWarning);
            this.grpWarning.Location = new System.Drawing.Point(37, 379);
            this.grpWarning.Name = "grpWarning";
            this.grpWarning.Size = new System.Drawing.Size(694, 30);
            this.grpWarning.TabIndex = 7;
            this.grpWarning.TabStop = false;
            this.grpWarning.Text = "Warning Codes";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(88, 10);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(876, 679);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Location = new System.Drawing.Point(755, 32);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(0, 13);
            this.lblDateAndTime.TabIndex = 8;
            // 
            // frmRemoteFlightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 749);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpControls);
            this.Controls.Add(this.grpWarning);
            this.Controls.Add(this.grpPlane);
            this.Controls.Add(this.grpAutopilot);
            this.Controls.Add(this.grpLiveUpdates);
            this.Controls.Add(this.grpConnection);
            this.Controls.Add(this.lbltitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoteFlightController";
            this.Text = "Remote Flight Controller";
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiveUpdates)).EndInit();
            this.grpLiveUpdates.ResumeLayout(false);
            this.grpAutopilot.ResumeLayout(false);
            this.grpAutopilot.PerformLayout();
            this.grpPlane.ResumeLayout(false);
            this.grpPlane.PerformLayout();
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCurrentThrottle.ResumeLayout(false);
            this.grpCurrentThrottle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkElevator)).EndInit();
            this.grpWarning.ResumeLayout(false);
            this.grpWarning.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.DataGridView dgvLiveUpdates;
        private System.Windows.Forms.Label lblCurrentConnection;
        private System.Windows.Forms.GroupBox grpLiveUpdates;
        private System.Windows.Forms.GroupBox grpAutopilot;
        private System.Windows.Forms.Label lblAutopilotDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnLand;
        private System.Windows.Forms.Button btnTakeOff;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVerticalSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPitchAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAltitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmThrottle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmElevatorPitch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmWarningCode;
        private System.Windows.Forms.GroupBox grpPlane;
        private System.Windows.Forms.GroupBox grpControls;
        private System.Windows.Forms.TrackBar trkThrottle;
        private System.Windows.Forms.TrackBar trkElevator;
        private System.Windows.Forms.GroupBox grpWarning;
        private System.Windows.Forms.Label lblElevatorPitchControlLabel;
        private System.Windows.Forms.Label lblThrottleControlLabel;
        private System.Windows.Forms.Label lblMaxThrottle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCurrentElevator;
        private System.Windows.Forms.GroupBox grpCurrentThrottle;
        private System.Windows.Forms.Label lblCurrentThrottle;
        private System.Windows.Forms.Label lblMinElevator;
        private System.Windows.Forms.Label lblMinThrottle;
        private System.Windows.Forms.Label lblMaxElevator;
        private System.Windows.Forms.Label lblElevatorPitch;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label lblVerticalSpeed;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblThrottle;
        private System.Windows.Forms.Label lblPitchAngle;
        private System.Windows.Forms.Label lblAirspeed;
        private System.Windows.Forms.Label lblElevatorPitchLabel;
        private System.Windows.Forms.Label lblAltitudeLabel;
        private System.Windows.Forms.Label lblVerticalSpeedLabel;
        private System.Windows.Forms.Label lblDistanceLabel;
        private System.Windows.Forms.Label lblThrottleLabel;
        private System.Windows.Forms.Label lblPitchAngleLabel;
        private System.Windows.Forms.Label lblAirspeedLabel;
        private System.Windows.Forms.Label lblDistanceRemaining;
        private System.Windows.Forms.Label lblDistanceRemainingLabel;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolTip ttThrottle;
        private System.Windows.Forms.ToolTip ttElevator;
        private System.Windows.Forms.ToolTip ttLiveUpdates;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.ToolTip ttConnect;
    }
}

