using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class AlbumTemplateControl : UserControl
    {
        private Album m_Album;
        public event EventHandler AlbumClicked;

        public AlbumTemplateControl()
        {
            InitializeComponent();
            albumCover.Click += OnAlbumCoverClick;
        }

        public void SetAlbum(Album i_Album)
        {
            m_Album = i_Album;
            Title.Text = m_Album.Name ?? "Unnamed Album";
            Date.Text = (m_Album.CreatedTime?.ToString("dd/MM/yyyy") ?? "Unknown");

            if (m_Album.Photos != null && m_Album.Photos.Count > 0)
            {
                albumCover.ImageLocation = m_Album.Photos[0].PictureNormalURL;
            }
            else
            {
                albumCover.Image = null; 
            }
        }

        protected virtual void OnAlbumCoverClick(object sender, EventArgs e)
        {
            AlbumClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
