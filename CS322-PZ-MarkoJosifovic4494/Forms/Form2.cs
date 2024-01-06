using CS322_PZ_MarkoJosifovic4494.Repo;
using CS322_PZ_MarkoJosifovic4494.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CS322_PZ_MarkoJosifovic4494
{

    public partial class Form2 : Form
    {
        private readonly UserService _userService;

        public Form2()
        {

            InitializeComponent();

            var dbContext = new MovieDbContext();
            var userRepository = new UserRepository(dbContext);
            _userService = new UserService(userRepository);

            this.FormClosed += new FormClosedEventHandler(Form2_FormClosed);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;

            form1.Location = this.Location;

            this.Hide();

            form1.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;
            string surname = textBox4.Text;
            string email = textBox5.Text;
            DateTime dateOfBirth = dateTimePicker1.Value;

            try
            {
                var newUser = _userService.RegisterUser(username, password, name, surname, email, dateOfBirth);
                MessageBox.Show("Registration successful!");



                Form1 form1 = new Form1();
                form1.StartPosition = FormStartPosition.Manual;

                form1.Location = this.Location;

                this.Hide();

                form1.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration failed: {ex.Message}");
            }
        }
    }
}
