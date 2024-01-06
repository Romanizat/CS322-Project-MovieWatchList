using CS322_PZ_MarkoJosifovic4494.Entity;
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
    public partial class MovieDetailsForm : Form
    {
        private readonly Movie _movie;
        public MovieDetailsForm(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
        }

        private void MovieDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
