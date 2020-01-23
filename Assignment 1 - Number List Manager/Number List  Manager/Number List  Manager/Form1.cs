using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_List__Manager
{
    public partial class Form1 : Form
    {

        bool spaceLeft = true;
        private int numberToDelete;
        int numberToInput;//int to store the number to input so we can run checks on it before inputting
        int noOfSpaceLeft;//int to track how many spaces are left in the list
        int insertIndex = 0;//int to store the index to insert next number

        const int maxNumbersInList = 30; // determins the max numbers in list
        public Form1()
        {
            InitializeComponent();
            RunChecks();
        }

        private void btnInitialise_Click(object sender, EventArgs e)//when initilise is clicked
        {

            Random rnd = new Random();//new random


            RunChecks();


            if (radUnsorted.Checked == true)//if unsorted
            {
                RunChecks();
                do
                {
                    numberToInput = (rnd.Next(0, 101));//sets number to input to random number
                    int i = 1;

                    while (i < lstNumbers.Items.Count)//loops though whole list
                    {
                        if (numberToInput == Convert.ToInt32(lstNumbers.Items[i]))//checks that number doesnt already exist in list
                        {
                            numberToInput = (rnd.Next(0, 101));//genrate new random number
                            i = 0;//set to 0 to restart checking through the list
                        }
                        else//if the number isnt at i index
                        {
                            i++;//move onto next number
                        }

                    }
                    lstNumbers.Items.Insert(i - 1, numberToInput);//insert the number

                    RunChecks();//check if the list is full
                } while (spaceLeft == true);//keep looping untill list is full


            }


            if (radSorted.Checked == true)//if sorted is checked
            {
                RunChecks();

                for (int i = 0; i < noOfSpaceLeft; i++)//loop through to add as many numbers as are left
                {
                    numberToInput = rnd.Next(0, 101);//generate random number
                    bool numberExists;//bool will be true if number is found

                    if (lstNumbers.Items.Count == 0)//if list is empty
                    {
                        lstNumbers.Items.Add(numberToInput);//add the first number
                        continue;
                    }



                    do///this section to keep looping untill we have a random number thats not in list
                    {
                        for (int j = 0; j < lstNumbers.Items.Count; j++)//loop though each item in list
                        {

                            if (Convert.ToInt32(lstNumbers.Items[j]) == numberToInput)//if generated number == j item in list
                            {
                                numberExists = true;//the number exists
                                numberToInput = rnd.Next(0, 101);//generate new random number
                                j = -1;//start loop counter again to start checking from the first element

                            }
                        }
                        numberExists = false;//nymber doesnt exist
                    } while (numberExists == true);//while the random number exists in the list




                    ///find out the the sorted position index for number about to be added

                    for (int k = 0; k < lstNumbers.Items.Count; k++) //loop through the current list.
                    {

                        if (numberToInput > Convert.ToInt32(lstNumbers.Items[k]))//if the number about to be put into list is greater than k index in list
                        {
                            insertIndex = k + 1;
                        }
                        else//if its smaller (already made sure it cant be equal above)
                        {
                            insertIndex = k;//index location is same as k
                            break; //we dont need to go all the way to the end of the for loop as we have alread found our index
                        }
                    }
                    if (insertIndex < 0)//to not go out of scope
                        insertIndex = 0;




                    /// this section to move the number to the correct index
                    lstNumbers.Items.Add(numberToInput);//add the number to the end of the list (making a new space)

                    for (int l = lstNumbers.Items.Count - 1; l > insertIndex; l--)//loop backwards from the end of the list untill we hit the sorted index
                    {
                        lstNumbers.Items[l] = lstNumbers.Items[l - 1];//starting from the end the index we look at = the one before it
                    }//at this point the number at insertindex and insertindex+1 are the same
                    lstNumbers.Items[insertIndex] = numberToInput;//overrite the duplicate at insert index with number to input


                }
                RunChecks();//check button status



            }
        }//btnInitialise_Click

        private void RunChecks()//function to call to do checks to enable and disable form operatins depending on how many items in list also to check if there is spacesleft and apply it to the bool spaceleft
        {
            if (lstNumbers.Items.Count == maxNumbersInList)//if there is 30 items in list, list is full
            {
                spaceLeft = false;
            }
            if ((lstNumbers.Items.Count < 0) || (lstNumbers.Items.Count > maxNumbersInList))
            {
                spaceLeft = false;
            }
            if ((lstNumbers.Items.Count > -1) && (lstNumbers.Items.Count < maxNumbersInList))//if there is more than -1 and less than 30 then there are spaces left
            {
                spaceLeft = true;
            }
            if (spaceLeft == false)//if there is no spaces left, initilise button should be diabled
            {
                btnInitialise.Enabled = false;
                btnInsert.Enabled = false; //insert button disabled
                txtInsert.Enabled = false; //textbox for insert diabled
            }
            if (spaceLeft == true)//if there are spaces left, initilise button should be enabled
            {
                btnInitialise.Enabled = true;
                btnInsert.Enabled = true;//insert button enabled
                txtInsert.Enabled = true;//textbox for insert enabled
            }
            if (lstNumbers.Items.Count > 0)//if there is at least 1 iteam in list then clear button is enabled
            {
                btnClear.Enabled = true;
            }
            if (lstNumbers.Items.Count == 0)//if there 0 items in list
            {
                btnClear.Enabled = false;//clear button disabled
                lblProbes.Text = "";
                lblFound.Text = "";
                lblPosition.Text = "";
                lblFirst.Text = "";
                lblLast.Text = "";
                lblMin.Text = "";
                lblMax.Text = "";

            }
            if (lstNumbers.Items.Count > 1)//if there is at least 2 items in list
            {
                btnShuffle.Enabled = true;//shuffle button enabled
                txtSearch.Enabled = true;//search textbox enabled
                btnSearch.Enabled = true;//search button enabled
                radLinear.Enabled = true;
                radBinary.Enabled = true;
            }
            if (lstNumbers.Items.Count < 2)//if there is less than 2 items in list
            {
                btnShuffle.Enabled = false;//shuffle button disabled
                txtSearch.Enabled = false;//search textbox diabled
                btnSearch.Enabled = false;//search button diabled
                radLinear.Enabled = false;
                radBinary.Enabled = false;
            }
            noOfSpaceLeft = maxNumbersInList - lstNumbers.Items.Count;//setting number of spaces left in the list
            lblMaxEntries.Text = Convert.ToString(maxNumbersInList);

            lblCount.Text = Convert.ToString(lstNumbers.Items.Count);
            if (lstNumbers.Items.Count != 0)
            {
                lblFirst.Text = Convert.ToString(lstNumbers.Items[0]);

                lblLast.Text = Convert.ToString(lstNumbers.Items[lstNumbers.Items.Count - 1]);
                int min = 101;
                int max = 0;
                for (int i = 0; i < lstNumbers.Items.Count; i++)
                {
                    if (min > Convert.ToInt32(lstNumbers.Items[i]))
                    {
                        min = Convert.ToInt32(lstNumbers.Items[i]);
                    }
                    if (max < Convert.ToInt32(lstNumbers.Items[i]))
                    {
                        max = Convert.ToInt32(lstNumbers.Items[i]);
                    }
                }
                lblMin.Text = Convert.ToString(min);
                lblMax.Text = Convert.ToString(max);

                lblMaxEntries.Text = Convert.ToString(maxNumbersInList);
            }



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (lstNumbers.Items.Count != 0)//loop while list isnt empty
            {
                lstNumbers.Items.RemoveAt(lstNumbers.Items.Count - 1);//remove last number in list
            }
            txtSearch.Clear();
            txtInsert.Clear();
            RunChecks();//update buttons 

        }

        private void radSorted_CheckedChanged(object sender, EventArgs e)///this is for if the list is generated unsorted then changed to sorted
        {
            int i, j, tmp;//3 variables, i holds one item in list. j to hold another. Tmp holds the temporary number while swapping the values in the other 2

            for (i = 1; i < lstNumbers.Items.Count; i++)//loop for each item in list
            {

                j = i;//save the index of list item as j

                while (j > 0 && Convert.ToInt32(lstNumbers.Items[j - 1]) > Convert.ToInt32(lstNumbers.Items[j]))//while index is greater than 0 and value of index j-1 is greater than value of index j
                {
                    tmp = Convert.ToInt32(lstNumbers.Items[j]);//save j value as tmp
                    lstNumbers.Items[j] = lstNumbers.Items[j - 1];//j value now = value in j-1
                    lstNumbers.Items[j - 1] = tmp;//save tmp value (originally j) to j-1
                    j--; //j = j-1
                }

            }            RunChecks();
        }

        private bool ValidateInput()//function to make sure the user is entering an expected value into the list. (only unique numbers between 0-100)
        {

            for (int i = 0; i < lstNumbers.Items.Count; i++)//loops through whole list
            {
                if (Convert.ToInt32(lstNumbers.Items[i]) == numberToInput)//if the number about to be input is = to a number in the list
                {
                    MessageBox.Show("Number already exists in the list, try again!");//error message
                    txtInsert.Text = "";//reset textbox
                    return false;//failed test
                }
            }//after we have made sure there is no duplicated we check if the number is in the correct range
            if (numberToInput >= 0 && numberToInput <= 100)//if numbertoinput >= 0 and <=100 (between 0-100)
            {
                return true;//pass test
            }
            else
            {
                MessageBox.Show("Number needs to be between 0 and 100");//error message for the user
                txtInsert.Text = "";//reset textbox
                return false; //failed test
            }

        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try//try to convert string to int
            {
                numberToInput = Convert.ToInt32(txtInsert.Text);//setting the number to input to what user has typed in textbox
            }
            catch//if it cant (not a number) 
            {
                MessageBox.Show("Please enter whole numbers only.");//error message as what was entered was not a number
                txtInsert.Clear();//clear text
                return;

            }
            if (ValidateInput() == true)//if validation test is passed
            {
                if (radSorted.Checked == true)//if the list is sorted
                {
                    for (int k = 0; k < lstNumbers.Items.Count; k++) //loop through the current list.
                    {

                        if (numberToInput > Convert.ToInt32(lstNumbers.Items[k]))//if the number about to be put into list is greater than k index in list
                        {
                            insertIndex = k + 1;
                        }
                        else//if its smaller (already made sure it cant be equal above)
                        {
                            insertIndex = k;//index location is same as k
                            break; //we dont need to go all the way to the end of the for loop as we have alread found our index
                        }
                    }
                    if (insertIndex < 0)//to not go out of scope
                        insertIndex = 0;

                    lstNumbers.Items.Add(numberToInput);//add the number to the end of the list (making a new space)

                    for (int i = lstNumbers.Items.Count - 1; i > insertIndex; i--)//loop backwards from the end of the list untill we hit the sorted index
                    {
                        lstNumbers.Items[i] = lstNumbers.Items[i - 1];//starting from the end the index we look at = the one before it
                    }//at this point the number at insertindex and insertindex+1 are the same
                    lstNumbers.Items[insertIndex] = numberToInput;//overrite the duplicate at insert index with number to input
                    txtInsert.Text = "";//make the textbox blank

                }
                if (radUnsorted.Checked == true)//if user is inserting into a unsorrted list
                {
                    lstNumbers.Items.Add(numberToInput);//add item to end of list
                    txtInsert.Text = "";//make the textbox blank
                }
                RunChecks();//update buttons and textboxs
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int tmp = lstNumbers.SelectedIndex;//set temp to the number to delete

            for (int i = lstNumbers.SelectedIndex; i < lstNumbers.Items.Count - 1; i++)//loop from the number to delete up the list
            {
                lstNumbers.Items[i] = lstNumbers.Items[i + 1];//set current number to the next number
            }
            lstNumbers.Items[lstNumbers.Items.Count - 1] = tmp;//last number will be there twice now, overwrite and save number to delete in the last index 
            lstNumbers.Items.RemoveAt(lstNumbers.Items.Count - 1);//delete last index
            RunChecks();//update buttons and textboxs
        }
        void ShuffleList()//function to shuffle list
        {
            int listLength = lstNumbers.Items.Count;//setting list length to count of listbox

            Random rand = new Random();//new random

            for (int i = 0; i < listLength; i++)// loop list count amount of times
            {
                Swap(i, rand.Next(0, listLength));//call swap function to swap 2 elements. Passing i (for first index to swap) and next random number between 0 and listlength(as second index to swap) 
            }
        }
        void Swap(int a, int b)//swap function 
        {
            int temp = Convert.ToInt32(lstNumbers.Items[a]);// temp = value in a index in lisbox

            lstNumbers.Items[a] = lstNumbers.Items[b];// value in a/i index = value in b
            lstNumbers.Items[b] = Convert.ToString(temp);//value in b/(random number) in listbox = temp 


        }
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            radUnsorted.Checked = true;//set to unsorted
            ShuffleList();//call shuffle list function (which calls swap function)
            RunChecks();//update buttons and textboxes

        }

        private void radUnsorted_CheckedChanged(object sender, EventArgs e)
        {
            ShuffleList();//call shuffle list function (which calls swap function)
            RunChecks();//update buttons and textboxes
            radLinear.Checked = true;
            radBinary.Checked = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int probes = 0;
            int position = 0;
            bool found = false;

            if (radLinear.Checked == true)//if linear search is selected
            {
                for (int i = 0; i < lstNumbers.Items.Count; i++)//loop for count of numbers
                {

                    probes++;
                    if (txtSearch.Text == "")//if no number is entered
                    {
                        MessageBox.Show("Please enter a number between 1 and 100.");//error messagge
                        return;

                    }
                    if (Convert.ToInt32(txtSearch.Text) == Convert.ToInt32(lstNumbers.Items[i]))//if searched number matches a lisbox element
                    {

                        position = i + 1;//position = i+1

                        lblProbes.Text = probes.ToString();//set label for probes
                        found = true;
                        lblPosition.Text = position.ToString();//set label for position
                        break;
                    }

                }
            }

            else if (radBinary.Checked == true)//if user tries to do binary search in sorted list
            {
                int min = 0;//min to store first element in search range
                int N = lstNumbers.Items.Count;//n to stote count of numbers
                int max = N - 1;//max to store the last element in search range
                probes = 0;
                do
                {
                    int mid = (min + max) / 2;// mid to store the halfway point between min and max
                    if (Convert.ToInt32(txtSearch.Text) > Convert.ToInt32(lstNumbers.Items[mid]))//if searched number is greater than mid value 
                    {
                        min = mid + 1; //update first element in search range to mid +1 (now searching in the upper quartile)
                    }
                    else
                        max = mid - 1;// if searched number is less than mid point. Update last element in search range to mid -1 (now searching in the lower quartile)
                    if (Convert.ToInt32(lstNumbers.Items[mid]) == (Convert.ToInt32(txtSearch.Text)))//if mid is = to number of search
                    {
                        position = mid + 1;//setting position to the correct index mid+1                      
                        found = true;
                        probes = probes + 1;//incrementing probes
                        break;
                    }
                    probes = probes + 1;//incrementing probes 
                } while (min <= max);// keep repeating while min is less than max

            }
            if (found == true)
            {
                lblFound.Text = "Found";
                lblProbes.Text = probes.ToString();//setting probes label to probes value
                lblPosition.Text = position.ToString();//setting position label to position value
            }
            else if (found == false)
            {
                lblFound.Text = "Not Found";
                lblPosition.Text = "";
                lblProbes.Text = probes.ToString();//setting probes label to probes value

            }

        }

        private void radBinary_CheckedChanged(object sender, EventArgs e)
        {
            if ((radBinary.Checked == true) && (radUnsorted.Checked == true))
            {
                MessageBox.Show("Cannot do a binary search while list is unsorted, sort list first.");
                radLinear.Checked = true;
            }
        }

        private void txtInsert_Click(object sender, EventArgs e)
        {
            AcceptButton = btnInsert;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            AcceptButton = btnSearch;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pboxTrash.AllowDrop = true;
        }

        private void lstNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            pboxTrash.DoDragDrop(lstNumbers.SelectedIndex, DragDropEffects.Move);//do drag and drop from selected index to picture box
        }


        private void pboxTrash_DragDrop(object sender, DragEventArgs e)//frop event on picture box
        {
            lstNumbers.Items.RemoveAt(lstNumbers.SelectedIndex);//remove selected index


            RunChecks();

        }

        private void pboxTrash_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;//setting mouse icons 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }

