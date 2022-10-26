using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace covtestingg
{
    public partial class yuzde50 : Form
    {
        public yuzde50()
        {
            InitializeComponent();
        }
        PrintDialog prd = new PrintDialog();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://covid19.saglik.gov.tr");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            muzik muzik = new muzik();
            muzik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vericekme vericekme = new vericekme();
            vericekme.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument kagit = new PrintDocument();
            DialogResult yazdirmaislemi;
            yazdirmaislemi = prd.ShowDialog();
            kagit.PrintPage += Kagit_PrintPage;
            if (yazdirmaislemi == DialogResult.OK)
            {
                kagit.Print();
            }
        }

        private void Kagit_PrintPage(object sender, PrintPageEventArgs e)
        {
            string nyzcim1 = label1.Text;
            string nyzcim2 = label2.Text;
            string nyzcim3 = label3.Text;
            string nyzcim4 = label4.Text;
            string nyzcim8 = label8.Text;
            string nyzcim5 = label5.Text;
            string nyzcim6 = label6.Text;
            string nyzcim7 = label7.Text;
            string nyzcim9 = label9.Text;
            string nyzcim10 = label10.Text;
            Font yaziailesi = new Font("Arial", 6);
            SolidBrush Kalem = new SolidBrush(Color.Black);
            e.Graphics.DrawString(nyzcim1 + Environment.NewLine +
                nyzcim2 + Environment.NewLine +
                nyzcim3 + Environment.NewLine +
                nyzcim4 + Environment.NewLine +
                nyzcim8 + Environment.NewLine +
                nyzcim5 + Environment.NewLine +
                nyzcim6 + Environment.NewLine +
                nyzcim7 + Environment.NewLine +
                nyzcim9 + Environment.NewLine + nyzcim10, yaziailesi, Kalem, 10, 20);
        }
    }
}
