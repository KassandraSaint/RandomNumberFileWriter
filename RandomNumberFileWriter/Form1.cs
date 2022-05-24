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

namespace RandomNumberFileWriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            // Initializing variables to hold information for the loop
            int nOfNumbers;
            int randomNum;

            //Creating a Random object
            Random random = new Random();

            // Validating a correct input from the user
            if (int.TryParse(numberBox.Text, out nOfNumbers))
            {
                // Initializing a StreamReader variable
                StreamWriter outputFile;

                // Saving the file on a Desktop or showing an error message
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    // Creating a file with the specified name
                    outputFile = File.CreateText(saveFile.FileName);

                    // Generating random numbers and writing them to a specified file
                    for (int counter = 0; counter < nOfNumbers; counter++)
                    {
                        // Generating a random number
                        randomNum = random.Next(1, 101);
                        // Writing a number to a file
                        outputFile.WriteLine(randomNum);
                    }
                    // Closing the file
                    outputFile.Close();
                }
                else
                {
                    // Showing a message if user clicked Cancel button
                    MessageBox.Show("Save as was Canceled");
                }
            }
            else
            {
                // Showing a message if input was wrong
                MessageBox.Show("Wrong input. Enter a valid intager number.");
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Closing the form
            this.Close();
        }
    }
}
