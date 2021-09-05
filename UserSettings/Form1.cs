using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserSettings.BL;

namespace UserSettings
{
    public partial class Form1 : Form
    {
        private bool IsShtrodel = false;
        private bool IsFirstName = false; private bool IsLastName = false; private bool IsPhone = false;
        private bool IsZIP = false; private bool IsID = false; private bool IsEmail = false;
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsENGLetter(char c)
        {
            return ((c >= 'a' && c <= 'z')||(c >= 'A' && c <= 'Z'));
        }
        private void textBox_Names_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsENGLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        private void textBox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) //Only Numbers!
                e.KeyChar = char.MinValue;
        }
        private bool CheckForm()
        {
            bool flag = true;
            if (textBox_FirstName.Text.Length < 2)
            {
                flag = false;
                textBox_FirstName.BackColor = Color.Red;
            }
            else
            {
                textBox_FirstName.BackColor = Color.White;
            }
            if (textBox_ZipCode.Text.Length != 7)
            {
                flag = false;
                textBox_ZipCode.BackColor = Color.Red;
            }
            else
                textBox_ZipCode.BackColor = Color.White;
            if (textBox_ID.Text.Length != 8)
            {
                flag = false;
                textBox_ID.BackColor = Color.Red;
            }
            else
                textBox_ID.BackColor = Color.White;
            if (textBox_LastName.Text.Length < 2)
            {
                flag = false;
                textBox_LastName.BackColor = Color.Red;
            }
            else
                textBox_LastName.BackColor = Color.White;
            if (textBox_Phone.Text.Length != 7)
            {
                flag = false;
                textBox_Phone.BackColor = Color.Red;
            }
            else
                textBox_Phone.BackColor = Color.White;
            return flag;
        }
        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                MessageBox.Show("Thank You!");
            }
        }
        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@')
            {
                IsShtrodel = true;
            }
        }
    }
}
