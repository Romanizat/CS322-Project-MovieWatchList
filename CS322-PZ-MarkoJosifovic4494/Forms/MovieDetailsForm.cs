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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CS322_PZ_MarkoJosifovic4494.Forms
{
    public partial class MovieDetailsForm : Form
    {
        private Movie _movie;
        private User _currentUser;
        private UserMovie userMovie;
        private MovieService _MovieService;
        private Boolean isRatingChanged;
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
            RemoveLinkLabels();

            userMovie = _MovieService.GetUserMovieByUserAndMovie(_currentUser, _movie);

            if (userMovie != null)
            {

                if (userMovie.Status == MovieStatus.Watched)
                {
                    button1.Enabled = false;
                    button2.Enabled = false;
                    trackBar1.Value = (int)(userMovie.Rating * 2);
                    label8.Text = $"Rating: {userMovie.Rating}/5";
                    trackBar1.Enabled = false;
                    AddLinkLabel(button1, "Remove from watched?");
                }
                else if (userMovie.Status == MovieStatus.WatchList)
                {
                    button1.Enabled = true;
                    button2.Enabled = false;
                    AddLinkLabel(button2, "Remove from watch list?");
                }
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void AddLinkLabel(System.Windows.Forms.Button button, string text)
        {
            LinkLabel linkLabel = new LinkLabel
            {
                Text = text,
                AutoSize = true,
                Location = new Point(button.Location.X, button.Location.Y + button.Height + 5),
            };

            linkLabel.Click += LinkLabel_Click;
            this.Controls.Add(linkLabel);
        }

        private void RemoveLinkLabels()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                if (this.Controls[i] is LinkLabel)
                {
                    this.Controls.RemoveAt(i);
                }
            }
        }

        private void LinkLabel_Click(object sender, EventArgs e)
        {
            if (sender is LinkLabel linkLabel)
            {
                _MovieService.deleteUserMovie(userMovie);
                SetButtonStates(); // Refresh the button states after the update
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isRatingChanged == false)
            {
                MessageBox.Show("You must rate the movie before adding it to your watched movies list.");
                return;
            }
            double rating = trackBar1.Value / 2.0;
            _MovieService.AddOrUpdateUserMovie(_movie, _currentUser, MovieStatus.Watched, rating);
            SetButtonStates();
            MessageBox.Show("You have successfully added this movie to your watched movies list.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _MovieService.AddOrUpdateUserMovie(_movie, _currentUser, MovieStatus.WatchList, 0.0);
            SetButtonStates();
            MessageBox.Show("You have successfully added this movie to your watch list.");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            isRatingChanged = true;
            label8.Text = $"Rating: {trackBar1.Value / 2m}/5";
        }
    }
}
