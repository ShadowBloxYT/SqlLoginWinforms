using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlWindowsFormsBankLogin
{
    public partial class Loading : Form
    {
        string U;
        string P;
        float M;

        public Loading(string u, string p, float m)
        {
            InitializeComponent();
            U = u;
            P = p;
            M = m;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
            BankAcountPage acountPage = new BankAcountPage(U, P, M);
            acountPage.Show();
        }

    
    }
}
