using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2_winform
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            InfoLbl.Hide();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void exitlbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void borderpnl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if(infoButton.Text=="Show Info")
            {
                InfoLbl.Show();
                infoButton.Text = "Hide Info";
            }
            else
            {
                InfoLbl.Hide();
                infoButton.Text = "Show Info";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameBox.Text) && !string.IsNullOrEmpty(passwordbox.Text))
            {
                try
                {
                    List<string> strings = new List<string>();
                    strings.Add(richTextBox1.Text);
                    var user = new User(strings, usernameBox.Text, passwordbox.Text);
                    var serializer = new JsonSerializer();
                    using (var sw = new StreamWriter($"{usernameBox.Text}.json"))
                    {
                        using (var jw = new JsonTextWriter(sw))
                        {
                            jw.Formatting = Formatting.Indented;
                            serializer.Serialize(jw, user);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                errorLbl.Text = "Succesfull";
            }
            else
            {
                errorLbl.Text = "Username Or Password Cannot Be empty";
            }
            
        }
    }
}
