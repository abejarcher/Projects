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
    public partial class BlueBoxMovies : Form
    {
        public BlueBoxMovies()
        {
            InitializeComponent();

            this.Load += new EventHandler(BlueBoxMovies_Load);

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            BlueBoxMainMenu NewMainMenu = new BlueBoxMainMenu();
            this.Visible = false;
            NewMainMenu.Show();
        }


        private void BlueBoxMovies_Load(object sender, EventArgs e)
        {
        //Auto-populate DataGridView when form loads
            DataTable dtMovies = null;

            Walton_DB.FillDataTable_ViaSql(ref dtMovies, @"SELECT Title, ReleaseYear, ItemType FROM Item");


            dgvMovies.DataSource = dtMovies;
            dgvMovies.Refresh();

        }

    }
}
