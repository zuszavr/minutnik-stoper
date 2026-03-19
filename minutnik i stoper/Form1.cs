using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;

namespace minutnik_i_stoper
{
    public partial class Form1 : Form
    {
        int czmin = 0;
        int czsto = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer2.Interval = 1000;
        }

        private void bstart_MouseClick(object sender, MouseEventArgs e)
        {

            if (int.TryParse(tminuty.Text, out int min))
            {
                if (int.TryParse(tsekundy.Text, out int sek))
                {
                    czmin = min * 60 + sek;
                    minutnik.Text = TimeSpan.FromSeconds(czmin).ToString(@"mm\:ss");
                    timer1.Start();
                }
                else
                {
                    if (tsekundy.Text == "")
                    {
                        tsekundy.Text = "0";
                        sek = 0;
                        czmin = min * 60 + sek;
                        minutnik.Text = TimeSpan.FromSeconds(czmin).ToString(@"mm\:ss");
                        timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("Błąd sekund");
                    }
                }
            }
            else
            {
                if (tminuty.Text == "")
                {
                    tminuty.Text = "0";
                    min = 0;

                    if (int.TryParse(tsekundy.Text, out int sek))
                    {
                        czmin = min * 60 + sek;
                        minutnik.Text = TimeSpan.FromSeconds(czmin).ToString(@"mm\:ss");
                        timer1.Start();
                    }
                    else
                    {
                        if (tsekundy.Text == "")
                        {
                            tsekundy.Text = "0";
                            sek = 0;
                            czmin = min * 60 + sek;
                            minutnik.Text = TimeSpan.FromSeconds(czmin).ToString(@"mm\:ss");
                            timer1.Start();
                        }
                        else
                        {
                            MessageBox.Show("Błąd sekund");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Błąd minut");
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czmin > 0)
            {
                czmin--;
                minutnik.Text = TimeSpan.FromSeconds(czmin).ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Stoper");
            }
        }

        private void bstop_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }



        private void bstart2_MouseClick(object sender, MouseEventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            czsto++;
            stoper.Text = TimeSpan.FromSeconds(czsto).ToString(@"mm\:ss");
        }

        private void bstop2_MouseClick(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void breset2_MouseClick(object sender, MouseEventArgs e)
        {
            czsto = 0;
            stoper.Text = TimeSpan.FromSeconds(czmin).ToString(@"mm\:ss");
        }

        private void tminuty_MouseClick(object sender, MouseEventArgs e)
        {
            tminuty.Text = "";
        }

        private void tsekundy_MouseClick(object sender, MouseEventArgs e)
        {
            tsekundy.Text = "";
        }
    }
}
