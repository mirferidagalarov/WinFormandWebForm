using ClothesStoreManagmentSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesStoreManagmentSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username =textBox1.Text.ToLower();
            string password =textBox2.Text; 
            
            var exsisting=Database.Users.SingleOrDefault(x=> x.Username.ToLower() == username && CryptingHelper.Decrypt( x.Password) == password);
            if (exsisting !=null)
            {
                MessageBox.Show("Login Succesuffly");
                frmUsers frmUsers = new frmUsers();
                frmUsers.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Invalid user");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
