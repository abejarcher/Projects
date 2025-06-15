using System.Data.SqlClient;
using System.Data;

namespace BlueBoxDemo
{
    public partial class BlueBoxLogin : Form
    {
        public static int CustId = -1;
        public BlueBoxLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Using SQL Command & Parameters to prevent SQL Injection
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT CustomerID from Customer Where FirstName = @Name and Password = @Password";
            cmd.Parameters.Add("@Name", SqlDbType.VarChar, 100).Value = txtUserName.Text;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = txtPassword.Text;

            DataTable dt = null;
            if (Walton_DB.FillDataTable_ViaCmd(ref dt, ref cmd))
            {   // If row count > 0, then they entered a valid username and password
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Success");
                    // Code here to open Next Screen
                    BlueBoxMainMenu NewMainMenu = new BlueBoxMainMenu();
                    this.Visible = false;
                    NewMainMenu.Show();
                    CustId = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                }
                else
                {   // Rows returned = 0, then nothing matches username password
                    MessageBox.Show("Password Incorrect - Login Failed!");
                }
            }
            else
            {
                MessageBox.Show("Database / Network Error - Login Failed");
            }
        }

        private void TypeUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
