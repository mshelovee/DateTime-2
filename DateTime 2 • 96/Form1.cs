using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTime_2___96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            DateTime odemeGunu = new DateTime(2022, 8, 25);


            lblTarih.Text = "Tarih: " + bugun.ToShortDateString();
            lblOdemeGunu.Text = "Ödeme Günü: " + odemeGunu.ToShortDateString();
        }
    }
}
