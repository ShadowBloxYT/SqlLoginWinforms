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
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Server=GMRMLTV;Database=MyronLaiDB;User Id=sa;Password=GreatMinds110;");

        SqlDataAdapter adapter;

        SqlCommand command = new SqlCommand();




        public Form1()
        {
            InitializeComponent();


        }

        void loginCheck()
        {
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = $"SELECT * FROM Users WHERE Username = '{usernameInput.Text}' AND Passsword = '{passwordInput.Text}'";

            adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            connection.Close();

            if (table.Rows.Count >= 1)
            {
                Loading loading = new Loading();
                loading.Show();
                this.Hide();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginCheck();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginCheck();
            }
        }
        
    }
}
