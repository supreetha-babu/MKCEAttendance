using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKCE_Mini
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string UserType = comboBox1.SelectedItem.ToString();
            string UserName = textBox1.Text;
            string User_Password = textBox2.Text;

            if (UserType == "Admin")
            {
                if (UserName == "admin" && User_Password == "password")
                {
                    this.Hide();
                    var frmAdmin = new Admin_Screen();
                    frmAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid credentials","Invalid Credentials");
                }
            }
            else if (UserType == "Staff")
            {
                if (UserName == "staff" && User_Password == "password")
                {
                    this.Hide();
                    var frmStaff = new Staff_Home();
                    frmStaff.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid credentials", "Invalid Credentials");
                }

            }
            else if (UserType == "Student")
            {
                if (UserName == "student" && User_Password == "password")
                {
                    this.Hide();
                    var frmStudent = new Student_Home();
                    frmStudent.Show();
                }
                else
                {
                    MessageBox.Show("Please enter valid credentials", "Invalid Credentials");
                }
            }
        }

        private void TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
