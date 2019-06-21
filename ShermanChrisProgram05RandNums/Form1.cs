/*
 *Program name: ShermanChrisProgram05RandNums
 * Author:Chris Sherman
 * Date:6/21/19
 * Description: Computer generates random numbers, writes them to a file, reads them from the same file and places them
 *              into a ListBox
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShermanChrisProgram05RandNums
{
    public partial class randNumsListBox : Form
    {
        public randNumsListBox()
        {
            InitializeComponent();
        }

        private void writeToFileButton_Click(object sender, EventArgs e)
        {
            //check if is an int
            bool goodInput = false;
            goodInput = userInputValidator();

            //runs if user entered valid data
            if(goodInput)
            {
                createAndWriteRandNums();
            }
        }

        private void createAndWriteRandNums()
        {
            
        }

        //Validates data. Will return true if user entered good data, will return false if badData.
        //Multiple return statements
        //Checks if user entered an interger, if entered nothing, or entered outside valid range
        private bool userInputValidator()
        {
            //check if is int
            int numRands;

            try
            {
                numRands = int.Parse(randNumsTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter an integer 1-20");
                randNumsTextBox.Text = "";
            return false; //assigns goodInput to false
            }

            if(randNumsTextBox.Text == "")
            {
                MessageBox.Show("The textbox is empty. Please enter an interger 1-20");
                return false; //assigns goodInput to false
            }

            const int MIN_NUM_RANDOMS = 1;
            const int MAX_NUM_RANDOMS = 20;
            if(numRands < MIN_NUM_RANDOMS || numRands > MAX_NUM_RANDOMS)
            {
                MessageBox.Show("Outside range. Please enter an integer 1-20");
                return false;//assigns goodInput to false
            }
            else
            {
                return true; //returns true to goodInput allowing the methods to continue
            }
            
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            randNumsTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
