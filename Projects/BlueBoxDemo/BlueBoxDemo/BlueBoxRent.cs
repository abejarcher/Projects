using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueBoxDemo
{
    public partial class BlueBoxRent : Form
    {
        DataTable dtMovies = null;
        DataTable dtPaymentType = null;
        DataTable dtLocation = null;
        public BlueBoxRent()
        {
            InitializeComponent();
        }


        private void btnMenuReturn_Click(object sender, EventArgs e)
        {
            BlueBoxMainMenu NewMainMenu = new BlueBoxMainMenu();
            this.Visible = false;
            NewMainMenu.Show();
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BlueBoxRent_Load_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dtTransactions = null;
            cmd.CommandText = "SELECT Customer.FirstName + ' ' + Customer.LastName AS CustomerName, Item.Title AS MovieTitle, Location.LocationName AS Place, Rental.RentalDate AS Date, Amount, PaymentType.PaymentMethod AS Payment FROM Rental JOIN Customer ON Rental.CustomerID = Customer.CustomerID JOIN Item ON Rental.ItemID = Item.ItemID JOIN PaymentType ON Rental.PaymentID = PaymentType.PaymentID JOIN Location ON Rental.LocationID = Location.LocationID WHERE Rental.CustomerID = @CustomerID;";
            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = BlueBoxLogin.CustId;

            Walton_DB.FillDataTable_ViaCmd(ref dtTransactions, ref cmd);

            dgvTransactions.DataSource = dtTransactions;
            dgvTransactions.Refresh();
            //Auto-populate DataGridView when form loads

            Walton_DB.FillDataTable_ViaSql(ref dtMovies, @"SELECT Title, ItemID FROM Item");
            Walton_DB.FillDataTable_ViaSql(ref dtLocation, @"SELECT LocationName, LocationID FROM Location");
            Walton_DB.FillDataTable_ViaSql(ref dtPaymentType, @"SELECT PaymentMethod, PaymentID FROM PaymentType");

            foreach (DataRow dr in dtPaymentType.Rows)
            {
                cmbPaymentType.Items.Add(dr["PaymentMethod"].ToString());
            }

            foreach (DataRow dr in dtMovies.Rows)
            {
                cmbMovies.Items.Add(dr["Title"].ToString());
            }

            foreach (DataRow dr in dtLocation.Rows)
            {
                cmbLocation.Items.Add(dr["LocationName"].ToString());
            }


        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            if (cmbPaymentType.SelectedIndex == -1 && cmbLocation.SelectedIndex == -1 && cmbMovies.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a Movie, Payment Type, and Location");
                return;
            }


            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Rental (CustomerID, ItemID, LocationID, PaymentID, RentalDate, Amount) VALUES (@CustomerID,@ItemID,@LocationID,@PaymentID, GETDATE(), 5.99)";
            cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = BlueBoxLogin.CustId;
            cmd.Parameters.Add("@ItemID", SqlDbType.Int).Value = dtMovies.Rows[cmbMovies.SelectedIndex]["ItemID"];
            cmd.Parameters.Add("@LocationID", SqlDbType.Int).Value = dtLocation.Rows[cmbLocation.SelectedIndex]["LocationID"];
            cmd.Parameters.Add("@PaymentID", SqlDbType.Int).Value = dtPaymentType.Rows[cmbPaymentType.SelectedIndex]["PaymentID"];

            if (Walton_DB.ExecSqlCommand(ref cmd))
            {
                MessageBox.Show("You have Successfully made a Rental");
                SqlCommand cmd2 = new SqlCommand();
                DataTable dtTransactions = null;
                cmd2.CommandText = "SELECT Customer.FirstName + ' ' + Customer.LastName AS CustomerName, Item.Title AS MovieTitle, Location.LocationName AS Place, Rental.RentalDate AS Date, Amount, PaymentType.PaymentMethod AS Payment FROM Rental JOIN Customer ON Rental.CustomerID = Customer.CustomerID JOIN Item ON Rental.ItemID = Item.ItemID JOIN PaymentType ON Rental.PaymentID = PaymentType.PaymentID JOIN Location ON Rental.LocationID = Location.LocationID WHERE Rental.CustomerID = @CustomerID;";
                cmd2.Parameters.Add("@CustomerID", SqlDbType.Int).Value = BlueBoxLogin.CustId;

                Walton_DB.FillDataTable_ViaCmd(ref dtTransactions, ref cmd2);

                dgvTransactions.DataSource = dtTransactions;
                dgvTransactions.Refresh();
            }
            else
            {
                MessageBox.Show("You have not Successfully made a Rental");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
