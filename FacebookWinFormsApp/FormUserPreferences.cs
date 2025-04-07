using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    public partial class FormUserPreferences : Form
    {
        private UserPreferences UserPreferences { get; set; }

        public FormUserPreferences(UserPreferences i_UserPreferences)
        {
            InitializeComponent();
            UserPreferences = i_UserPreferences;
            loadPreferences();
        }

        private void loadPreferences()
        {
            checkBoxAutoRefresh.Checked = UserPreferences.AutoRefreshFeed;
            numericUpDownRefreshInterval.Value = UserPreferences.RefreshInterval;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UserPreferences.AutoRefreshFeed = checkBoxAutoRefresh.Checked;
            UserPreferences.RefreshInterval = (int)numericUpDownRefreshInterval.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}