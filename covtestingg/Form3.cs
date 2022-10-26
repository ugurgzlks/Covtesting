using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;

namespace covtestingg
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void temizle()
            {
            textbox1.Text = "";
            textbox2.Text = "";
            textbox3.Text = "";
            textbox4.Text = "";
            textbox5.Text = "";
            textbox6.Text = "";

        }


       // OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Data.accdb");

        private void butonkayitol_Click(object sender, EventArgs e)
        {
            try
            {
                //string sorgu = "insert into Kisiler (Kullanicino,Kullaniciadi,Sifre,Adi,Soyadi,Telefon) values(@kulno,@kuladi,@sifre,@isim,@soyisim,@telefon) ";
                //OleDbCommand komut = new OleDbCommand(sorgu, baglanti);
                //komut.Parameters.AddWithValue("@kulno", textbox1.Text);
                //komut.Parameters.AddWithValue("@kuladi", textbox2.Text);
                //komut.Parameters.AddWithValue("@sifre", textbox3.Text);
                //komut.Parameters.AddWithValue("@isim", textbox4.Text);
                //komut.Parameters.AddWithValue("@soyisim", textbox5.Text);
                //komut.Parameters.AddWithValue("@telefon", textbox6.Text);
                //baglanti.Open();
                //komut.ExecuteNonQuery();
                MessageBox.Show("Kaydınız başarıyla oluşturulmuştur.");
                temizle();
                Form2 frm2 = new Form2();
                frm2.Show();
                Hide();
            }
            catch
            {
                MessageBox.Show("Lütfen bilgilerinizi kontrol ederek tekrar giriniz .");
                temizle();
            }


            //baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            checkBox1.Visible = false;
            textbox3.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                textbox3.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textbox3.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = false;
            }
        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = false;
            }
        }

        private void textbox4_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = false;
            }
        }

        private void textbox5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = false;
            }
        }

        private void textbox6_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = false;
            }
        }

        private void textbox3_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = true;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            muzik muzik = new muzik();
            muzik.Show();
        }
    }
}
