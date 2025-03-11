using _3Sports.data;
using _3Sports.UI.SubForms;
using System.Collections;
using System.Data.Linq;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace _3Sports.UI
{
    
    public partial class RugbyView : Form
    {
        //string username = UserSession.Current.UserName;
        public RugbyView()
        {
            InitializeComponent();
        }
        
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            SportSelectView mainPage = new SportSelectView();
            this.Close();
            mainPage.Show();
        }

        private void picBath_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.BathSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.BathSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picBristol_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.BristolSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.BristolSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picExeter_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.ExeterSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.ExeterSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picGloucester_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.GloucesterSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.GloucesterSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picLeicester_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.LeicesterSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.LeicesterSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picHarlequins_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.HarlequinsSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.HarlequinsSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picNorthampton_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.NorthamptonSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.NorthamptonSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picNewcastle_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.NewcastleSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.NewcastleSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picSale_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.SaleSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.SaleSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void picSaracens_Click(object sender, System.EventArgs e)
        {
            this.teams2024TableAdapter.SaracensSelect(this.premiershipRugbyDataDataSet.Teams2024);
            this.teams2025TableAdapter.SaracensSelect(this.premiershipRugbyDataDataSet.Teams2025);
        }

        private void btnPlayersShow_Click(object sender, System.EventArgs e)
        {
            RugbyPlayersView player = new RugbyPlayersView();
            player.Show();
            this.Close();
        }

        private void RugbyView_Load(object sender, System.EventArgs e)
        {
            //lblUser.Text = username;
        }
    }
}
