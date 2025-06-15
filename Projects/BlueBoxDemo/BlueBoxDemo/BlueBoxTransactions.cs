using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BlueBoxDemo
{
    public partial class BlueBoxTransactions : Form
    {
        public BlueBoxTransactions()
        {
            InitializeComponent();

            this.Load += new EventHandler(BlueBoxTransactions_Load);
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            BlueBoxMainMenu NewMainMenu = new BlueBoxMainMenu();
            this.Visible = false;
            NewMainMenu.Show();
        }
        private void BlueBoxTransactions_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dtTransactions = null;
            cmd.CommandText = "SELECT Customer.FirstName + ' ' + Customer.LastName AS CustomerName, Item.Title AS MovieTitle, Location.LocationName AS Place, Rental.RentalDate AS Date, PaymentType.PaymentMethod AS Payment FROM Rental JOIN Customer ON Rental.CustomerID = Customer.CustomerID JOIN Item ON Rental.ItemID = Item.ItemID JOIN PaymentType ON Rental.PaymentID = PaymentType.PaymentID JOIN Location ON Rental.LocationID = Location.LocationID WHERE Rental.CustomerID = @CustomerID;";
            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = BlueBoxLogin.CustId;

            Walton_DB.FillDataTable_ViaCmd(ref dtTransactions, ref cmd);

            dgvTransactions.DataSource = dtTransactions;
            dgvTransactions.Refresh();

        }

        private void dgvTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
