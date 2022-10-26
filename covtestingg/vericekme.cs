using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covtestingg
{
    public partial class vericekme : Form
    {
        public vericekme()
        {
            InitializeComponent();
        }

        private void vericekme_Load(object sender, EventArgs e)
        {
            string[] CoronaVerileri, CoronaGunlukVeriBilgisi; // 2 adet dizi oluşturduk.

            using (WebClient wc = new WebClient())
            {
                var url = wc.DownloadString("https://raw.githubusercontent.com/ozanerturk/covid19-turkey-api/master/dataset/timeline.json");
                //güncel bilgileri url olarak aldık 
                CoronaVerileri = url.ToString().Split('{');
                // "{" işareti ile ayırıp diziye aktarmış olduk.
            }

            for (int i = 1; i <= 10; i++)
            {
                CoronaGunlukVeriBilgisi = CoronaVerileri[CoronaVerileri.Length - i].Split('"');
                if (i == 1)
                {
                    baslik.Text = CoronaGunlukVeriBilgisi[3] + "   COVİD HASTA TABLOSU"; //Günün tarihi gelsin
                }
                //Aynı işlemi tarih,test sayısı,vaka,iyileşen,vefat için de yapalım.

                tarih.ListView.Items.Add(CoronaGunlukVeriBilgisi[3]);
                testsayisi.ListView.Items.Add(CoronaGunlukVeriBilgisi[31]);
                vaka.ListView.Items.Add(CoronaGunlukVeriBilgisi[35]);
                iyilesen.ListView.Items.Add(CoronaGunlukVeriBilgisi[55]);
                vefat.ListView.Items.Add(CoronaGunlukVeriBilgisi[51]);

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            muzik muzik = new muzik();
            muzik.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
