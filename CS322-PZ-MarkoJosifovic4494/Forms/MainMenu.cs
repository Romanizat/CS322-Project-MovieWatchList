using CS322_PZ_MarkoJosifovic4494.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_PZ_MarkoJosifovic4494.Forms
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(MainMenu_FormClosed);

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserContext.CurrentUser = null;
            this.Hide();
            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.Manual;

            form1.Location = this.Location;

            form1.Show();


        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
