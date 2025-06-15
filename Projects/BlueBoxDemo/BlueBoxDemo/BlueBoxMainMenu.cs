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
    public partial class BlueBoxMainMenu : Form
    {
        public BlueBoxMainMenu()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //This is rent button
        {
            BlueBoxRent NewRent = new BlueBoxRent();
            this.Visible = false;
            NewRent.Show();
        }

        private void button2_Click(object sender, EventArgs e) //This is Locations button
        {
            BlueBoxLocations NewLocations = new BlueBoxLocations();
            this.Visible = false;
            NewLocations.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            BlueBoxLogin NewLogin = new BlueBoxLogin();
            this.Visible = false;
            NewLogin.Show();
        }

        private void btnMovieList_Click(object sender, EventArgs e)
        {
            BlueBoxMovies NewMovies = new BlueBoxMovies();
            this.Visible = false;
            NewMovies.Show();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            BlueBoxTransactions NewTransactions = new BlueBoxTransactions();
            this.Visible = false;
            NewTransactions.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
