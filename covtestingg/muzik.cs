using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covtestingg
{
    public partial class muzik : Form
    {
        public muzik()
        {
            InitializeComponent();
        }
         
        private void muzik_Load(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.Visible = false;
        }

        private void muzik_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            axWindowsMediaPlayer1.URL = Application.StartupPath + @"\muzik.mp4";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.close();
            Close();
        }
    }
}
