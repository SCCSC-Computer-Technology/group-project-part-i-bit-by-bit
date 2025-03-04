/** 
 * GROUP PROJECT #1
 * CPT - 206 
 * 
 * SETTINGS VIEW
**/

using System;
using System.Windows.Forms;

namespace _3Sports.UI.SubForms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        // Log Out button
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Close button
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Application Restart button
        private void btnRestart_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Application.Restart();
        }

        // Save all settings methd
        private void SaveSettings()
        {
            try
            {
                // All Save Auth + Password Change data will be saved logic
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
