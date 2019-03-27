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

namespace SqlWindowsFormsBankLogin
{
    public partial class BankAcountPage : Form
    {
        string Username;
        string Password;
        float Money;

        public BankAcountPage(string username, string password, float money)
        {
            InitializeComponent();
            Username = username;
            Password = password;
            Money = money;
        }

        SqlConnection connection = new SqlConnection("Server=GMRMLTV;Database=MyronLaiDB;User Id=sa;Password=GreatMinds110;");

        SqlDataAdapter adapter;

        SqlCommand command = new SqlCommand();

        Form1 form = new Form1();

        private void isItClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            float moneyToWithdraw = int.Parse(withdrawAmount.Text);
            float moneyUpdated = Money -= moneyToWithdraw;
            command.CommandText = $"UPDATE Users SET Money = {moneyUpdated} WHERE Username = '{Username}'";
            command.ExecuteNonQuery();
            MessageBox.Show("You have gotten less cash");
            connection.Close();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            float moneyToDeposit = int.Parse(depositAmount.Text);
            float moneyUpdated = Money += moneyToDeposit;
            command.CommandText = $"UPDATE Users SET Money = {moneyUpdated} WHERE Username = '{Username}'";
            command.Connection = connection;
            command.ExecuteNonQuery();
            MessageBox.Show("You have gotten more cash");
            connection.Close();
        }
    }
}
