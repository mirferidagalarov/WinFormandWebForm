using ClothesStoreManagmentSystem.Model;
using ClothesStoreManagmentSystem.Operations.concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClothesStoreManagmentSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserManager userManager = new UserManager();
            string username = textBox1.Text;
            string password = textBox2.Text;
            var usermodel = new User();
            usermodel.ID= userManager.GetNextId();
            usermodel.Username = username;
            usermodel.Password = password;

         

            var result = userManager.Add(usermodel);

            if (result.IsSucces)
            {
                MessageBox.Show(result.Message);
                Login login = new Login();
                login.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show(result.Message);
                textBox2.Text = string.Empty;
                textBox1.Text = string.Empty;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
