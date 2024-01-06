using CS322_PZ_MarkoJosifovic4494.Entity;
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
        private readonly Movie _movie;
        public MovieDetailsForm(Movie movie)
        {
            InitializeComponent();
            _movie = movie;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            richTextBox1.ReadOnly = true;

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
    }
}
