using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    public partial class FormUserPreferences : Form
    {
        private UserPreferences m_UserPreferences;

        public FormUserPreferences(UserPreferences i_UserPreferences)
        {
            InitializeComponent();
            m_UserPreferences = i_UserPreferences;
            loadPreferences();
        }

        private void loadPreferences()
        {
            checkBoxAutoRefresh.Checked = m_UserPreferences.AutoRefreshFeed;
            numericUpDownRefreshInterval.Value = m_UserPreferences.RefreshInterval;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            m_UserPreferences.AutoRefreshFeed = checkBoxAutoRefresh.Checked;
            m_UserPreferences.RefreshInterval = (int)numericUpDownRefreshInterval.Value;
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