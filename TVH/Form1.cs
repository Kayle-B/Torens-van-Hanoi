using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace TVH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void forloopButton_Click(object sender, EventArgs e)
        {
            int input;
            BigInteger answer = 1;

            int.TryParse(inputTextBox.Text, out input);
            if (input <= 64 && input >= 1)
            {
                for (int i = 1; i < input; i++)
                {
                    answer = answer * 2 + 1;
                }
                outputLabel.Text = string.Format("{0}", answer);
            }
            else
            {
                MessageBox.Show("Helaas werkt dit niet");
            }

            // DIT TELT DE TIJD
            {
                string sSeconds = outputLabel.Text;
                BigInteger iSeconds = BigInteger.Parse(sSeconds);

                BigInteger iMillenia = iSeconds / 31576908800;
                iSeconds = iSeconds % 31576908800;

                BigInteger iYears = iSeconds / 31556926;
                iSeconds = iSeconds % 31556926;

                BigInteger iDays = iSeconds / 86400;
                iSeconds = iSeconds % 86400;

                BigInteger iHours = iSeconds / 3600;
                iSeconds = iSeconds % 3600;

                BigInteger iMinutes = iSeconds / 60;
                iSeconds = iSeconds % 60;
                // DIT HIERBOVEN TELT DE TIJD 



                milleniaCount.Text = "Millenia: " + iMillenia.ToString();
                yearCount.Text = "Jaren: " + iYears.ToString();
                dayCount.Text = "Dagen: " + iDays.ToString();
                hourCount.Text = "Uren: " + iHours.ToString();
                minuteCount.Text = "Minuten: " + iMinutes.ToString();
                secondCount.Text = "Seconden: " + iSeconds.ToString();


            }

        }


        private void machtButton_Click_1(object sender, EventArgs e)
        {
            int input;
            BigInteger answer;
            int.TryParse(inputTextBox.Text, out input);

            if (input <= 64 && input >= 1)
            {

                answer = (BigInteger)(Math.Pow(2, input) - 1);
                outputLabel.Text = string.Format("{0}", answer);
            }
            else
            {
                MessageBox.Show("Helaas werkt dit niet");
            }





            // DIT TELT DE TIJD
            {
                string sSeconds = outputLabel.Text;
                BigInteger iSeconds = BigInteger.Parse(sSeconds);

                BigInteger iMillenia = iSeconds / 31576908800;
                iSeconds = iSeconds % 31576908800;

                BigInteger iYears = iSeconds / 31556926;
                iSeconds = iSeconds % 31556926;

                BigInteger iDays = iSeconds / 86400;
                iSeconds = iSeconds % 86400;

                BigInteger iHours = iSeconds / 3600;
                iSeconds = iSeconds % 3600;

                BigInteger iMinutes = iSeconds / 60;
                iSeconds = iSeconds % 60;
                // DIT HIERBOVEN TELT DE TIJD

                milleniaCount.Text = "Millenia: " + iMillenia.ToString();
                yearCount.Text = "Jaren: " + iYears.ToString();
                dayCount.Text = "Dagen: " + iDays.ToString();
                hourCount.Text = "Uren: " + iHours.ToString();
                minuteCount.Text = "Minuten: " + iMinutes.ToString();
                secondCount.Text = "Seconden: " + iSeconds.ToString();
            }

        }
    }
}
