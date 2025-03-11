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
    public partial class AppInfo : Form
    {

        public AppInfo()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            var confirmRestart = MessageBox.Show("Are you sure you want to restart the application?", "Confirm Restart",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmRestart == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Remember this will close the application
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Clears the session and redirects to the login form
            LoginView loginForm = new LoginView();
            loginForm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Redirects to the Sport Selection View
            this.Hide();
            SportSelectView sportSelectView = new SportSelectView();
            sportSelectView.Show();
            this.Close();
        }
    }
}

