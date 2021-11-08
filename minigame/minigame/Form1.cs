using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace minigame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> gep_sorrend = new List<int>() { };
        List<int> jatekos_sorrend = new List<int>() { };
        int kör_szám = 0;

        public void kör_fv()
        {
            Random rnd = new Random();
            int sorszam = rnd.Next(1, 10);
            gep_sorrend.Add(sorszam);

            foreach (var elem in gep_sorrend)
            {
                szinezo(elem);
                Application.DoEvents();
                Thread.Sleep(400);
            }
            jatekos_sorrend = new List<int>();
            
        }

        public bool ellenorzes_fv()
        {
            if (gep_sorrend.SequenceEqual(jatekos_sorrend))
            {
                return true;
            }
            else
            {
                MessageBox.Show("vége");
                return false;
                
            }
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            //új játék
            gep_sorrend = new List<int>();
            jatekos_sorrend = new List<int>();
            kör_szám = 0;

            kör_fv();
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (ellenorzes_fv())
            {
                kör_szám++;
                round_value.Text = kör_szám.ToString();
                kör_fv();
            }
            
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sender == button1) jatekos_sorrend.Add(1);
            if (sender == button2) jatekos_sorrend.Add(2);
            if (sender == button3) jatekos_sorrend.Add(3);
            if (sender == button4) jatekos_sorrend.Add(4);
            if (sender == button5) jatekos_sorrend.Add(5);
            if (sender == button6) jatekos_sorrend.Add(6);
            if (sender == button7) jatekos_sorrend.Add(7);
            if (sender == button8) jatekos_sorrend.Add(8);
            if (sender == button9) jatekos_sorrend.Add(9);
        }


        public void szinezo(int sorszam)
        {
            //adott gombot átszínezi
            if (sorszam == 1) button1.BackColor = Color.Red;
            if (sorszam == 2) button2.BackColor = Color.Orange;
            if (sorszam == 3) button3.BackColor = Color.Yellow;
            if (sorszam == 4) button4.BackColor = Color.Lime;
            if (sorszam == 5) button5.BackColor = Color.Aqua;
            if (sorszam == 6) button6.BackColor = Color.Blue;
            if (sorszam == 7) button7.BackColor = Color.Fuchsia;
            if (sorszam == 8) button8.BackColor = Color.FromArgb(64,64,64);
            if (sorszam == 9) button9.BackColor = Color.White;

            Application.DoEvents();
            Thread.Sleep(800);

            button1.BackColor = Color.FromArgb(255, 128, 128);
            button2.BackColor = Color.FromArgb(255, 192, 128);
            button3.BackColor = Color.FromArgb(255, 255, 128);
            button4.BackColor = Color.FromArgb(128, 255, 128);
            button5.BackColor = Color.FromArgb(128, 255, 255);
            button6.BackColor = Color.FromArgb(128, 128, 255);
            button7.BackColor = Color.FromArgb(255, 128, 255);
            button8.BackColor = Color.Gray;
            button9.BackColor = Color.Silver;

        }

       
    }
}
