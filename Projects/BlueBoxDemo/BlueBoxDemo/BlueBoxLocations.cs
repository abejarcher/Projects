using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueBoxDemo
{
    public partial class BlueBoxLocations : Form
    {
        public BlueBoxLocations()
        {
            InitializeComponent();

            this.Load += new EventHandler(BlueBoxLocations_Load);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            BlueBoxMainMenu NewMainMenu = new BlueBoxMainMenu();
            this.Visible = false;
            NewMainMenu.Show();
        }

        private void BlueBoxLocations_Load(object sender, EventArgs e)
        {
            //Auto-populate DataGridView when form loads
            DataTable dtLocation = null;

            Walton_DB.FillDataTable_ViaSql(ref dtLocation, @"SELECT LocationName, Address, City, State, Zip FROM Location");


            dgvLocation.DataSource = dtLocation;
            dgvLocation.Refresh();

        }
    }
}
