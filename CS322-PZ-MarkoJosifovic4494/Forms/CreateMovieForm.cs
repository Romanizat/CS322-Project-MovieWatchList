using CS322_PZ_MarkoJosifovic4494.Service;
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
    public partial class CreateMovieForm : Form
    {
        private readonly MovieService _movieService;
        public CreateMovieForm(MovieService movieService)
        {
            InitializeComponent();
            _movieService = movieService;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string title = textBox1.Text;
            string imdb = textBox2.Text;
            string imageUrl = textBox3.Text;
            string summary = richTextBox1.Text;

            if (title == "" || imdb == "" || imageUrl == "" || summary == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            _movieService.CreateMovie(title, summary, imdb, imageUrl);

            this.Close();
        }
    }
}
