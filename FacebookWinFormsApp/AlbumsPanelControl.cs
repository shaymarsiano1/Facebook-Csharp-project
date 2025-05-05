using System;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System.Threading;

namespace FacebookWinFormsApp
{
    public partial class AlbumsPanelControl : BasePanelControl
    {
        public AlbumsPanelControl()
        {
            InitializeComponent();
            LoggedInUser = FacebookUserSingleton.Instance.LoggedInUser;
            InitializeData();
        }

        public override void InitializeData()
        {
            base.InitializeData();
            Controls.Clear();

            Controls.Add(new Label()
            {
                Text = "Loading Your Albums...",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0),
                AutoSize = true
            });

            Thread thread = new Thread(() => UpdateAlbums());
            thread.Start();
        }

        public void UpdateAlbums()
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                AutoSize = false
            };

            try
            {
                if (LoggedInUser.Albums == null || LoggedInUser.Albums.Count == 0)
                {
                    Label noAlbumsLabel = new Label
                    {
                        Text = "No albums found",
                        AutoSize = true,
                        Margin = new Padding(10)
                    };
                    flowLayoutPanel.Controls.Add(noAlbumsLabel);

                    return;
                }

                foreach (Album album in LoggedInUser.Albums)
                {
                    if (album != null)
                    {
                        AlbumTemplateControl albumCard = new AlbumTemplateControl();
                        albumCard.SetAlbum(album);
                        albumCard.AlbumClicked += (s, e) => showAlbumPhotos(album);
                        flowLayoutPanel.Controls.Add(albumCard);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading albums: {ex.Message}");
                Label errorLabel = new Label
                {
                    Text = $"Error loading albums: {ex.Message}",
                    AutoSize = true,
                    Dock = DockStyle.Fill
                };

                flowLayoutPanel.Controls.Add(errorLabel);
            }

            Invoke(new Action(() =>
            {
                Controls.Clear();
                Controls.Add(flowLayoutPanel);
            }));
        }

        private void showAlbumPhotos(Album i_Album)
        {
            Controls.Clear();

            FlowLayoutPanel photosPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };
            Button backButton = new Button
            {
                Text = "Back to Albums",
                AutoSize = true,
                Margin = new Padding(10)
            };

            backButton.Click += (s, e) => UpdateAlbums();
            photosPanel.Controls.Add(backButton);
            Random rand = new Random();
            foreach (Photo photo in i_Album.Photos) 
            {
                int likesNumber = photo.LikedBy.Count != 0 ? photo.LikedBy.Count : rand.Next(100);

                if (photo != null && string.IsNullOrEmpty(photo.PictureNormalURL) == false) 
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 150,
                        Height = 150,
                        Margin = new Padding(5),
                        ImageLocation = photo.PictureNormalURL
                    };
                    Label likesLabel = new Label();
                    likesLabel.Text = $"\u2661 {likesNumber}";
                    bool wasLiked = false;
                    likesLabel.ForeColor = Color.White;
                    likesLabel.BackColor = Color.FromArgb(120, 0, 0, 0); 
                    likesLabel.Font = new Font("Segoe UI", 15);
                    likesLabel.AutoSize = false;
                    likesLabel.TextAlign = ContentAlignment.MiddleCenter;
                    likesLabel.Dock = DockStyle.Bottom;
                    likesLabel.Height = 30;

                    likesLabel.Click += (s, e) =>
                    {
                        try
                        {
                            if (wasLiked == true) 
                            {
                                wasLiked = false;
                                likesLabel.Text = $"\u2661 {likesNumber}";
                                photo.Unlike();
                            }
                            else
                            {
                                wasLiked = true;
                                likesLabel.Text = $"\u2665 {likesNumber + 1}";
                                photo.Like();     
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Doesn't support this function yet");
                        }
                    };

                    pictureBox.Controls.Add(likesLabel);
                    photosPanel.Controls.Add(pictureBox);
                }
            }
            Controls.Add(photosPanel);
        }
    }
}