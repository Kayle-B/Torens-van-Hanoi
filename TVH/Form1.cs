using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            int input;
            ulong answer;
            int.TryParse(inputTextBox.Text, out input);

            answer = (ulong)(Math.Pow(2, input) - 1);
            outputLabel.Text = string.Format("{0}", answer);

        }

        private void forloopButton_Click(object sender, EventArgs e)
        {
            double input;
            double answer = 1;
            double.TryParse(inputTextBox.Text, out input);

            for(int i= 1; i < input; i++)
            {
                answer = answer * 2 + 1;
            }
            outputLabel.Text = string.Format("{0}", answer);
        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
