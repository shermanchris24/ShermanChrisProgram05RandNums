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
using System.IO;

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
            // //will have the user save the file to create, unless the user cancels the save;
            bool goodInput = false;
            bool savedFile = false;//if user saved file will be true if not false
            goodInput = userInputValidator();

            if (goodInput)
            {
                savedFile = SaveFile();//if user saves the file this function will call createAndWriteRandumNums();

            }

            //runs if user entered valid data
            if(savedFile)
            {     
                writeRandsToFile();   
            }
        }

        //creates file and writes random numbers to it
        private void writeRandsToFile()
        {
            const int MIN_RANDOM_NUMBER = 1;
            const int MAX_RANDOM_NUMBER = 100;
            int numRands = int.Parse(randNumsTextBox.Text);
            int currentRandInt;
            Random rand = new Random();
            string fileLocation = saveFileDialog1.FileName;
            StreamWriter outputFile;

            outputFile = File.CreateText(fileLocation);

            for(int i = 0; i < numRands; i++)
            {
                currentRandInt = rand.Next(MIN_RANDOM_NUMBER, MAX_RANDOM_NUMBER); //generates numbers between 1-99
                outputFile.WriteLine(currentRandInt.ToString()); 
            }
            outputFile.Close();//closed the file
            
        }

        private bool SaveFile()
        {

            
            //if else below mostly taken from textbook p324 gaddis starting out with visual c#5th ed
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                return true;

            }
            else
            {
                MessageBox.Show("You clicked the Cancel button. Must select save in order to write to a file");
                return false;
            }
        }



        //Validates data. Will return true if user entered good data, will return false if badData.
        //Multiple return statements
        //Checks if user entered an interger, if entered nothing, or entered outside valid range/
        private bool userInputValidator()
        {
            int numRands;

            if(randNumsTextBox.Text == "")
            {
                MessageBox.Show("The textbox is empty. Please enter an interger 1-20");
                return false; //assigns goodInput to false
            }

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



            const int MIN_NUM_RANDOMS = 1;
            const int MAX_NUM_RANDOMS = 20;
            if(numRands < MIN_NUM_RANDOMS || numRands > MAX_NUM_RANDOMS)
            {
                MessageBox.Show("Outside range. Please enter an integer 1-20");
                return false;//assigns goodInput to false
            }
            else
            {
                return true; //returns true to goodInput e
            }


          
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            //Fixme Could not find File
            try
            {
                OpenFileDialog myOpenFileDialog = new OpenFileDialog();
                
                if (myOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("You clicked the Open button.");
                    string fileLocation = myOpenFileDialog.FileName;//FIXME need to add a check to make sure not an empty string? i think

                    MessageBox.Show(fileLocation);
                    StreamReader inputFile = File.OpenText(fileLocation);
                    int sum = 0;
                    while (!inputFile.EndOfStream)
                    {
                        int currentInt = int.Parse(inputFile.ReadLine());
                        listBox1.Items.Add(currentInt.ToString());
                        sum += currentInt;
                    }

                    totalLabelBlank.Text = sum.ToString();
                }


                else
                {
                    MessageBox.Show("You clicked the Cancel button.");
                }



            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
