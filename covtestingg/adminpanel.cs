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
    public partial class adminpanel : Form
    {
        public adminpanel()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti;
        OleDbCommand komut;
        OleDbDataAdapter da;

        public void kullanicigetir() 
        {
            //baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Data.accdb");
            //baglanti.Open();
            //da = new OleDbDataAdapter("select * FROM Kisiler", baglanti);
            //DataTable table = new DataTable();
            //da.Fill(table);
            //dataGridView1.DataSource = table;
            //baglanti.Close();
        }

        public void temizle() 
        {
            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();
            text5.Clear();
            text6.Clear();
        }

        

        private void adminpanel_Load(object sender, EventArgs e)
        {
            kullanicigetir();
            temizle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            text1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            text2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            text3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            text4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            text5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            text6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            try
            {
                //string sorgu = "insert into Kisiler (Kullanicino,Kullaniciadi,Sifre,Adi,Soyadi,Telefon) values (@kulno,@kuladi,@sifre,@ad,@soyad,@tel) ";
                //komut = new OleDbCommand(sorgu, baglanti);
                //komut.Parameters.AddWithValue("@kulno", text1.Text);
                //komut.Parameters.AddWithValue("@kuladi", text2.Text);
                //komut.Parameters.AddWithValue("@sifre", text3.Text);
                //komut.Parameters.AddWithValue("@ad", text4.Text);
                //komut.Parameters.AddWithValue("@soyad", text5.Text);
                //komut.Parameters.AddWithValue("@tel", text6.Text);
                //baglanti.Open();
                //komut.ExecuteNonQuery();
                //baglanti.Close();
                //kullanicigetir();
                //temizle();
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu lütfen tekrar deneyin .");
            }



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                //string sorgu = "delete from Kisiler where Kullanicino=@kulno ";
                //komut = new OleDbCommand(sorgu, baglanti);
                //komut.Parameters.AddWithValue("@kulno", text1.Text);
                //baglanti.Open();
                //komut.ExecuteNonQuery();
                //baglanti.Close();
                //kullanicigetir();
                temizle();
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu lütfen tekrar deneyin .");
            }
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {

                //string sorgu = "UPDATE Kisiler SET  Kullaniciadi=@kulad, Sifre=@sif,  Adi=@ad, Soyadi=@soyad, Telefon=@tel WHERE Kullanicino=@kulno ";
                ////string sorgu = "UPDATE Kisiler SET Kullanicino=@kulno , Kullaniciadi=@kulad, Sifre=@sif,  Adi=@ad, Soyadi=@soyad, Telefon=@tel ";
                //komut = new OleDbCommand(sorgu, baglanti);
                //komut.Parameters.AddWithValue("@kulno", text1.Text);
                //komut.Parameters.AddWithValue("@kulad", text2.Text);
                //komut.Parameters.AddWithValue("@sif", text3.Text);
                //komut.Parameters.AddWithValue("@ad", text4.Text);
                //komut.Parameters.AddWithValue("@soyad", text5.Text);
                //komut.Parameters.AddWithValue("@tel", text6.Text);
                //baglanti.Open();
                //komut.ExecuteNonQuery();
                //baglanti.Close();
                //kullanicigetir();
                temizle();

                
            }
            catch
            {
                MessageBox.Show("Bir hata oluştu lütfen tekrar deneyin .");
            }
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Hide();
        }
    }
}
