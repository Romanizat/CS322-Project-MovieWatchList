using CS322_PZ_MarkoJosifovic4494.Entity;
using CS322_PZ_MarkoJosifovic4494.Repo;
using CS322_PZ_MarkoJosifovic4494.Service;
using CS322_PZ_MarkoJosifovic4494.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_PZ_MarkoJosifovic4494.Forms
{
    public partial class MainMenu : Form
    {
        private readonly MovieService _movieService;

        public MainMenu()
        {
            InitializeComponent();
            var dbContext = new MovieDbContext();
            var movieRepository = new MovieRepository(dbContext);
            var userMovieRepository = new UserMovieRepository(dbContext);

            _movieService = new MovieService(movieRepository, userMovieRepository);
            this.FormClosed += new FormClosedEventHandler(MainMenu_FormClosed);
            dataGridView1.AllowUserToAddRows = false;


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

        private void button3_Click(object sender, EventArgs e)
        {
            string searchKeyword = textBox1.Text;

            if (searchKeyword.Equals("Search Movies in DB..."))
            {
                searchKeyword = "";
            }

            List<Movie> movies = _movieService.FindAllByTitle(searchKeyword);

            PopulateListView(movies);
        }

        private void PopulateListView(List<Movie> movies)
        {
            dataGridView1.Rows.Clear();

            foreach (var movie in movies)
            {
                int rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];
                row.Cells["Title"].Value = movie.Title;
                row.Cells["Summary"].Value = movie.Summary;
                row.Cells["Rating"].Value = movie.GetRating();
                row.Cells["Details"].Value = "Details"; // Set for DataGridViewLinkColumn
                row.Tag = movie; // Store the movie object in the row's Tag property
            }
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the 'Details' button or link was clicked
            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn ||
                dataGridView1.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
            {
                // Retrieve the Movie object from the row's Tag property
                var movie = (Movie)dataGridView1.Rows[e.RowIndex].Tag;

                // Open the details form
                MovieDetailsForm detailsForm = new MovieDetailsForm(movie, _movieService);

                detailsForm.StartPosition = FormStartPosition.Manual;

                detailsForm.Location = this.Location;

                detailsForm.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateMovieForm createMovieForm = new CreateMovieForm(_movieService);
            createMovieForm.StartPosition = FormStartPosition.Manual;
            createMovieForm.Location = this.Location;
            createMovieForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PopulateListView(_movieService.GetAllWatchedMoviesForLoggedInUser());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateListView(_movieService.GetAllWatchListMoviesForLoggedInUser());
        }

        private void textBox1_Enter_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Search Movies in DB...")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.WindowText; // Set text color to default
            }
        }

        private void textBox1_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Search Movies in DB...";
                textBox1.ForeColor = SystemColors.GrayText; // Set text color to gray to indicate placeholder text
            }
        }
    }
}
