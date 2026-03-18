using Microsoft.Win32.SafeHandles;
using System.Diagnostics.CodeAnalysis;

namespace minutnik_i_stoper
{
    public partial class Form1 : Form
    {
        int czmin = 0;
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
                    MessageBox.Show("Błąd sekund");
                }
            }
            else
            {
                if (tminuty.Text == "")
                {
                    tminuty.Text = "0";
                    min = 0;

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
    }
}
