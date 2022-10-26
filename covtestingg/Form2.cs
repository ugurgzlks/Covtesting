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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        
        public void temizle() 
        {
            textbox1.Clear();
            textbox2.Clear();
        }

        //OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Application.StartupPath +"\\Data.accdb");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            Hide();
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            //baglanti.Open();
            //OleDbCommand cmd = new OleDbCommand("select * from Kisiler where Kullaniciadi= '" + textbox1.Text + "'and Sifre='" + textbox2.Text + "'", baglanti);
            //OleDbDataReader dr = cmd.ExecuteReader();
            //if (dr.Read())
            //{
            //    kullaniciekran1 klncekrn1 = new kullaniciekran1();
            //    klncekrn1.Show();
            //    Hide();

            //}
            if (textbox1.Text=="ugurgzlks" && textbox2.Text=="05380755004")
            {
                adminpanel admpnl = new adminpanel();
                admpnl.Show();
                Hide();
            }
            else if(textbox1.Text=="" || textbox2.Text=="")
            {
                MessageBox.Show("Lütfen doldurulması gereken alanları boş bırakmayın .");
            }
            else
            {
                kullaniciekran1 klncekrn1 = new kullaniciekran1();
                klncekrn1.Show();
                Hide();
                temizle();
            }
            //baglanti.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //MessageBox.Show("Merhaba. Covtesting uygulamamıza hoşgeldiniz. Kullanıcı adınızı ve şifrenizi girerek uygulamaya başlayabilirsiniz. Eğer kayıtlı değilseniz lütfen kayıt ol seçeneği ile kayıt olunuz. Teşekkür ederiz. ");
            textbox1.Text = "ugurgzlks";
            textbox2.Text = "05380755004";
            textbox2.UseSystemPasswordChar = true; 
            checkBox1.Visible = false;   
            
        }

        private void textbox2_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = true;
            }



        }

        private void textbox1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                checkBox1.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                textbox2.UseSystemPasswordChar = false;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textbox2.UseSystemPasswordChar = true;
                checkBox1.Text = "Göster";
            }
        }

        

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            muzik muzik = new muzik();
            muzik.Show();
            
        }
    }
}
