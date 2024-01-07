using CS322_PZ_MarkoJosifovic4494.Entity;
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
    public partial class MovieDetailsForm : Form
    {
        private Movie _movie;
        private User _currentUser;
        private MovieService _MovieService;
        public MovieDetailsForm(Movie movie, MovieService movieService)
        {
            InitializeComponent();
            _movie = movie;
            _MovieService = movieService;
            _currentUser = UserContext.CurrentUser;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            richTextBox1.ReadOnly = true;
            SetButtonStates();
        }

        private async void MovieDetailsForm_Load(object sender, EventArgs e)
        {
            label1.Text = _movie.Title;
            richTextBox1.Text = _movie.Summary;
            linkLabel1.Text = _movie.Imdb;
            label6.Text = _movie.GetRating();

            pictureBox1.Image = await LoadImageFromUrlAsync(_movie.Image);
        }

        private async Task<Image> LoadImageFromUrlAsync(string url)
        {
            using (var webClient = new WebClient())
            {
                try
                {
                    byte[] imageData = await webClient.DownloadDataTaskAsync(url);
                    using (var ms = new MemoryStream(imageData))
                    {
                        return Image.FromStream(ms);
                    }
                }
                catch (WebException)
                {
                    return null;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = linkLabel1.Text,
                    UseShellExecute = true
                };
                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link.");
            }
        }

        private void SetButtonStates()
        {
            // Check if the movie is in the watched list
            bool isWatched = _currentUser.UserMovies
                .Any(um => um.Movie.Id == _movie.Id && um.Status == MovieStatus.Watched);

            // Check if the movie is in the watch list
            bool isInWatchList = _currentUser.UserMovies
                .Any(um => um.Movie.Id == _movie.Id && um.Status == MovieStatus.WatchList);

            // Enable or disable buttons based on the movie status
            button1.Enabled = !isWatched; // Add to Watched button
            button2.Enabled = !isInWatchList && !isWatched; // Add to Watch List button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _MovieService.AddOrUpdateUserMovie(_movie, _currentUser, MovieStatus.Watched);
            SetButtonStates();
            MessageBox.Show("You have successfully added this movie to your watched movies list.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _MovieService.AddOrUpdateUserMovie(_movie, _currentUser, MovieStatus.WatchList);
            SetButtonStates();
            MessageBox.Show("You have successfully added this movie to your watch list.");
        }
    }
}
