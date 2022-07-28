using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2_winform
{
    public partial class CalculatorForm : Form
    {
        double number = 0;
        char operation = ' ';
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public CalculatorForm()
        {
            InitializeComponent();
            //resultLbl.Text = "";
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitLbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button_Click(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                if (richTextBox1.Text == "0" && richTextBox1.Text != null)
                {
                    richTextBox1.Text = "1";
                }
                else
                {
                    richTextBox1.Text += button.Text;
                }
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

       

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            //resultLbl.Text+="+";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            //resultLbl.Text+="-";    
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            //resultLbl.Text
            if (operation == '+')
            {

            }
            else if(operation == '-')
            {

            }
            else if(operation == 'x')
            {

            }
            else if(operation == '/')
            {

            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "/";
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "x";
        }

    }
}
