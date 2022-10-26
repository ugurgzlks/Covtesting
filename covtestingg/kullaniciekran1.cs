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
    public partial class kullaniciekran1 : Form
    {
        public kullaniciekran1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if ((radiobtn1.Checked || radiobtn2.Checked) &&
                    (radiobtn3.Checked || radiobtn4.Checked || radiobtn5.Checked || radiobtn6.Checked) &&
                    radiobtn7.Checked && radiobtn9.Checked &&
                    radiobtn11.Checked && radiobtn13.Checked &&
                    radiobtn15.Checked && radiobtn17.Checked &&
                    radiobtn19.Checked && radiobtn21.Checked &&
                    radiobtn23.Checked && radiobtn25.Checked &&
                    radiobtn27.Checked && radiobtn29.Checked
                    )
                {
                    MessageBox.Show("corona beliritisi %100");
                    yuzde100 yzd100 = new yuzde100();
                    yzd100.Show();
                    Hide();
                }

                else if ((radiobtn1.Checked || radiobtn2.Checked) &&
                         (radiobtn3.Checked || radiobtn4.Checked || radiobtn5.Checked || radiobtn6.Checked) &&
                         radiobtn7.Checked &&
                         (radiobtn9.Checked || radiobtn10.Checked) &&
                         radiobtn12.Checked &&
                         radiobtn14.Checked &&
                         (radiobtn15.Checked || radiobtn16.Checked) &&
                         radiobtn18.Checked &&
                         radiobtn20.Checked &&
                         (radiobtn22.Checked || radiobtn24.Checked)  &&
                         radiobtn24.Checked &&
                         radiobtn26.Checked &&
                         radiobtn27.Checked &&
                          radiobtn30.Checked
                    )
                {
                    MessageBox.Show("corona beliritisi %20");
                    yuzde50 yzd50 = new yuzde50();
                    yzd50.Show();
                    Hide();

                }

                else if ((radiobtn1.Checked || radiobtn2.Checked) &&
                         (radiobtn3.Checked || radiobtn4.Checked || radiobtn5.Checked || radiobtn6.Checked) &&
                         (radiobtn7.Checked || radiobtn8.Checked) &&
                         (radiobtn9.Checked || radiobtn10.Checked) &&
                         radiobtn11.Checked &&
                         radiobtn14.Checked &&
                         (radiobtn15.Checked || radiobtn16.Checked) &&
                         radiobtn18.Checked &&
                         radiobtn20.Checked &&
                         radiobtn22.Checked &&
                         radiobtn23.Checked &&
                         (radiobtn25.Checked || radiobtn26.Checked) &&
                         (radiobtn27.Checked || radiobtn28.Checked) &&
                         radiobtn30.Checked)
                {
                    MessageBox.Show("corona beliritisi %40");
                    yuzde50 yzd50 = new yuzde50();
                    yzd50.Show();
                    Hide();

                }

                else if ((radiobtn1.Checked || radiobtn2.Checked) &&
                         (radiobtn3.Checked || radiobtn4.Checked || radiobtn5.Checked || radiobtn6.Checked) &&
                         radiobtn8.Checked && radiobtn10.Checked &&
                         radiobtn12.Checked && radiobtn14.Checked &&
                         radiobtn16.Checked && radiobtn18.Checked &&
                         radiobtn20.Checked && radiobtn22.Checked &&
                         radiobtn24.Checked && radiobtn26.Checked &&
                         radiobtn28.Checked && radiobtn30.Checked)

                {
                    MessageBox.Show("corona beliritisi %0");
                    yuzde0 yzd0 = new yuzde0();
                    yzd0.Show();
                    Hide();

                }


                else if ((radiobtn1.Checked || radiobtn2.Checked) &&
                         (radiobtn3.Checked || radiobtn4.Checked || radiobtn5.Checked || radiobtn6.Checked) &&
                         radiobtn7.Checked &&
                         radiobtn9.Checked &&
                         (radiobtn11.Checked || radiobtn12.Checked) &&
                         radiobtn14.Checked &&
                         radiobtn15.Checked &&
                         (radiobtn18.Checked || radiobtn19.Checked) &&
                         radiobtn20.Checked &&
                         radiobtn22.Checked &&
                         (radiobtn23.Checked || radiobtn24.Checked) &&
                         radiobtn25.Checked &&
                         radiobtn27.Checked &&
                         radiobtn30.Checked)

                {
                    MessageBox.Show("corona beliritisi %60");
                    yuzde50 yzd50 = new yuzde50();
                    yzd50.Show();
                    Hide();

                }


                else if ((radiobtn1.Checked || radiobtn2.Checked) &&
                         (radiobtn3.Checked || radiobtn4.Checked || radiobtn5.Checked || radiobtn6.Checked) &&
                         radiobtn7.Checked &&
                         radiobtn9.Checked &&
                         radiobtn11.Checked &&
                         (radiobtn13.Checked || radiobtn14.Checked) &&
                         radiobtn15.Checked &&
                         (radiobtn17.Checked || radiobtn18.Checked) &&
                         radiobtn19.Checked &&
                         (radiobtn21.Checked || radiobtn22.Checked) &&
                         (radiobtn23.Checked  || radiobtn24.Checked) &&
                         radiobtn25.Checked &&
                         (radiobtn27.Checked || radiobtn28.Checked)&&
                         (radiobtn29.Checked || radiobtn30.Checked))

                {
                    MessageBox.Show("corona beliritisi %80");
                    yuzde50 yzd50 = new yuzde50();
                    yzd50.Show();
                    Hide();

                }

                else if ((radiobtn1.Checked || radiobtn2.Checked) &&
                         (radiobtn3.Checked || radiobtn4.Checked || radiobtn5.Checked || radiobtn6.Checked) &&
                         (radiobtn7.Checked || radiobtn8.Checked) &&
                         (radiobtn9.Checked || radiobtn10.Checked) &&
                         (radiobtn1.Checked || radiobtn8.Checked)  &&
                         (radiobtn13.Checked || radiobtn14.Checked) &&
                         (radiobtn15.Checked || radiobtn8.Checked)  &&
                         (radiobtn17.Checked || radiobtn18.Checked) &&
                         (radiobtn19.Checked || radiobtn8.Checked)  &&
                         (radiobtn21.Checked || radiobtn22.Checked) &&
                         (radiobtn23.Checked || radiobtn8.Checked)  &&
                         (radiobtn25.Checked || radiobtn26.Checked) &&
                         (radiobtn27.Checked || radiobtn8.Checked)  &&
                         (radiobtn29.Checked || radiobtn30.Checked))

                {
                    MessageBox.Show("corona beliritisi %50");
                    yuzde50 yzd50 = new yuzde50();
                    yzd50.Show();
                    Hide();

                }


                else
                {
                    MessageBox.Show(" Lütfen soruların hepsini cevapladığınızdan emin olun. ");
                    
                }
            }

            catch 
            {
                MessageBox.Show("bir hata oluştu lütfen tekrar deneyin");
            }


        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            muzik muzik = new muzik();
            muzik.Show();
        }
    }
}
