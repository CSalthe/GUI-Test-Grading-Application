// X1084
// Lab 6 
// 3/25/2018
// CIS 199-02
// This program takes a user input word per minute score and outputs a letter grade associated to the input typing score, using parrallel array range matching. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class wpmGrader : Form
    {
        public wpmGrader()
        {
            InitializeComponent();
        }
        // this event handeler executes the below code upon the clicking of the wpmButton 
        private void wpmButton_Click(object sender, EventArgs e)
        {
      

            int[] words = new int[] { 76, 51, 31, 16, 0 }; // This array holds the minimum values associated with each grade letter range  
            char[] grades = new char[] { 'A', 'B', 'C', 'D', 'F' }; // THis array holds the letter grade values associated to typing score ranges in the parrallel words array 

            int wpm; // This is the users input score on the typing test
            char grade = 'F'; // This is the associated letter grade derived from the user input wpm score 
            bool found = false;// This determines if the user input wpm score fits a given test score range 
            



            if (int.TryParse(wpmTextBox.Text, out wpm) && (wpm >= 0)) // Try parse the user input wpm score 
            {
                for (int i = 0; i < words.Length && !found; ++i) // Iterates through words loop to match user input value with pre set ranges 
                {
                    if (wpm >= words[i]) // IF statement to test if user input value matches pre set ranges 
                    {
                        found = true;
                        grade = grades[i];
                    }

                }
                // output
                gradeOutPut.Text = ($"{grade}");

            }
            else
            {
                //invalid user input 
                MessageBox.Show("Enter valid wpm");
            }
         





            }
    }
}
