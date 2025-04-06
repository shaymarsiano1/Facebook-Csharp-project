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
        public AlbumsPanelControl(User i_LoggedInUser, UserActivity i_UserActivity)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_UserActivity = i_UserActivity;
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
                m_UserActivity.PhotoViewCount++;

                if (m_LoggedInUser.Albums == null || m_LoggedInUser.Albums.Count == 0)
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

                foreach (Album album in m_LoggedInUser.Albums)
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

        private void showAlbumPhotos(Album album)
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

            foreach (Photo photo in album.Photos)
            {
                if (photo != null && !string.IsNullOrEmpty(photo.PictureNormalURL))
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 150,
                        Height = 150,
                        Margin = new Padding(5),
                        ImageLocation = photo.PictureNormalURL
                    };

                    photosPanel.Controls.Add(pictureBox);
                }
            }

            Controls.Add(photosPanel);
        }
    }
}