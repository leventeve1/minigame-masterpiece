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
            List<Button> gombok = new List<Button>
            {button1,button2,button3,button4,button5,button6,button7,button8,button9};
        }


        private void new_game_Click(object sender, EventArgs e)
        {
            //új játék
            int kör = 0;
            round_value.Text = kör.ToString();


            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int sorszam = rnd.Next(1, 10);
                szinezo(sorszam);

                Application.DoEvents();
                Thread.Sleep(400);
            }
            
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
