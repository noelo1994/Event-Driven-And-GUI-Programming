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
        int noOfSpaceLeft;

        const int maxNumbersInList = 101; // determins the max numbers in list
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitialise_Click(object sender, EventArgs e)//when initilise is clicked
        {
            
                                             // bool spaceLeft;//bool for if thers is spaces left, true or false
            Random rnd = new Random();//new random
            int numberToInput;

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


            if (radSorted.Checked == true)
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
                    int insertIndex = 0;//int to store the index to insert next number
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
              
                    for (int l=lstNumbers.Items.Count-1; l> insertIndex;l--)//loop backwards from the end of the list untill we hit the sorted index
                    {
                        lstNumbers.Items[l] = lstNumbers.Items[l - 1];//starting from the end the index we look at = the one before it
                    }//at this point the number at insertindex and insertindex+1 are the same
                    lstNumbers.Items[insertIndex] = numberToInput;//overrite the duplicate at insert index with number to input
                
               
                }
                RunChecks();//check button status



            }
        }//btnInitialise_Click

        private void RunChecks()//function to call to do checks to enable and disable form operatins depending on how many items in list
        {
            if (lstNumbers.Items.Count==maxNumbersInList)//is there is 30 items in list, list is full
            {
                spaceLeft = false;
            }
            if ((lstNumbers.Items.Count<0)||(lstNumbers.Items.Count>maxNumbersInList))
            {
                spaceLeft = false;
            }
            if ((lstNumbers.Items.Count>-1)&&(lstNumbers.Items.Count<maxNumbersInList))//if there is more than -1 and less than 30 then there are spaces left
            {
                spaceLeft = true;
            }
            if (spaceLeft==false)//if there is no spaces left, initilise button should be diabled
            {
                btnInitialise.Enabled = false;
            }
            if (spaceLeft==true)//if there are spaces left, initilise button should be enabled
            {
                btnInitialise.Enabled = true;
            }
            if (lstNumbers.Items.Count >0)//if there is at least 1 iteam in list then clear button is enabled
            {
                btnClear.Enabled = true;
            }
            if (lstNumbers.Items.Count==0)//if there 0 items in list
            {
                btnClear.Enabled = false;//clear button disabled
            }
            if(lstNumbers.Items.Count>1)//if there is at least 2 items in list
            {
                btnShuffle.Enabled = true;//shuffle button enabled
            }
            if(lstNumbers.Items.Count<2)//if there is less than 2 items in list
            {
                btnShuffle.Enabled = false;//shuffle button disabled
            }
            if (spaceLeft==false)//if there is no space in list
            {
                btnInsert.Enabled = false; //insert button disabled
                txtInsert.Enabled = false; //textbox for insert diabled
            }
            if (spaceLeft==true)//if there is spaces left
            {
                btnInsert.Enabled = true;//insert button enabled
                txtInsert.Enabled = true;//textbox for insert enabled
            }
            noOfSpaceLeft = maxNumbersInList - lstNumbers.Items.Count;//setting number of spaces left in the list
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (lstNumbers.Items.Count != 0)//loop while list isnt empty
            {
                lstNumbers.Items.RemoveAt(lstNumbers.Items.Count - 1);//remove last number in list
            }
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

            }
        }

      
    }
}

