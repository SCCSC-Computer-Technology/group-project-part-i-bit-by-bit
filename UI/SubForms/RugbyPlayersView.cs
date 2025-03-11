using _3Sports.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Sports.UI.SubForms
{
    public partial class RugbyPlayersView : Form
    {
        // string username = UserSession.CurrentUsername
        public RugbyPlayersView()
        {
            InitializeComponent();
        }

        
        
        private void picBristol_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.BristolPlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.BristolPlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picExeter_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.ExeterPlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.ExeterPlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picGloucester_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.GloucesterPlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.GloucesterPlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picLeicester_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.LeicesterPlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.LeicesterPlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picHarlequins_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.HarlequinsPlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.HarlequinsPlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picNorthampton_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.NorthamptonPlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.NorthamptonPlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picSale_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.SalePlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.SalePlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picNewcastle_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.NewcastlePlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.NewcastlePlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void picSaracens_Click(object sender, EventArgs e)
        {
            this.players2024TableAdapter.SaracensPlayerSelect(this.premiershipRugbyDataDataSet.Players2024);
            this.players2025TableAdapter.SaracensPlayerSelect(this.premiershipRugbyDataDataSet.Players2025);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RugbyView teams = new RugbyView();
            this.Close();
            teams.ShowDialog();
            
        }

        private void RugbyPlayersView_Load(object sender, EventArgs e)
        {
            //lblUser.Text = username;
        }
    }
}
