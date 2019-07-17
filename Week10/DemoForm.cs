using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10
{
    public partial class DemoForm : Form
    {
        public DemoForm(int number)
        {
            InitializeComponent();
            WelcomeLabel.Text = number + "";

            if (WelcomeLabel.Text == "0" || WelcomeLabel.Text == "5")
            {
                PreviousButton.Enabled = false;
            }
        }

        private void DemoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit()
        }
        //foward
        private void NextButton_Click(object sender, EventArgs e)
        {
            int currentIndex = Convert.ToInt32(WelcomeLabel.Text);
            Program.NavigateTo(currentIndex+1);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            int currentIndex = Convert.ToInt32(WelcomeLabel.Text);
            Program.NavigateTo(currentIndex - 1);
        }
    }
}
