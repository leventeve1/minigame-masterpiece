using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace minigame
{
    public partial class Form1 : Form
    {
        SoundPlayer correctSound = new SoundPlayer("sound/correct2.wav");
        SoundPlayer gameoverSound = new SoundPlayer("sound/wrong.wav");

        List<int> gepSorrend = new List<int>() { };
        List<int> jatekosSorrend = new List<int>() { };
        int körCounter = 0;

        public static Color button1ColorA = Color.Red;
        public static Color button2ColorA = Color.Orange;
        public static Color button3ColorA = Color.Yellow;
        public static Color button4ColorA = Color.Lime;
        public static Color button5ColorA = Color.Aqua;
        public static Color button6ColorA = Color.Blue;
        public static Color button7ColorA = Color.Fuchsia;
        public static Color button8ColorA = Color.FromArgb(64, 64, 64);
        public static Color button9ColorA = Color.White;

        public static Color button1ColorB = Color.FromArgb(255, 192, 192);
        public static Color button2ColorB = Color.FromArgb(255, 224, 192);
        public static Color button3ColorB = Color.FromArgb(255, 255, 192);
        public static Color button4ColorB = Color.FromArgb(192, 255, 192);
        public static Color button5ColorB = Color.FromArgb(192, 255, 255);
        public static Color button6ColorB = Color.FromArgb(192, 192, 255);
        public static Color button7ColorB = Color.FromArgb(255, 192, 255);
        public static Color button8ColorB = Color.Gray;
        public static Color button9ColorB = Color.DarkGray;

        public Form1()
        {
            InitializeComponent();
        }
        public void körFV()
        {
            Thread.Sleep(500);
            Random randomSzam = new Random();
            int hanyadikGomb = randomSzam.Next(1, 10);
            gepSorrend.Add(hanyadikGomb);

            foreach (var elem in gepSorrend)
            {
                szinezo(elem);
                Application.DoEvents();
                Thread.Sleep(400);
            }
            jatekosSorrend = new List<int>();
        }

        public bool  ellenorzesFV()
        {
            if (gepSorrend.SequenceEqual(jatekosSorrend))
            {
                return true;
            }
            else
            {
                gameoverSound.Play();
                MessageBox.Show("Hibás! A játék véget ért!");
                return false;
            }
        }

        private void new_game_Click(object sender, EventArgs e)
        {
            //új játék
            gepSorrend = new List<int>();
            jatekosSorrend = new List<int>();
            körCounter = 1;
            round_value.Text = körCounter.ToString();
            körFV();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (ellenorzesFV())
            {
                correctSound.Play();
                körCounter++;
                round_value.Text = körCounter.ToString();
                körFV();
            }

            else if (int.Parse(high_score_value.Text)<körCounter-1)
            {
                high_score_value.Text= (körCounter-1).ToString();
            }
            
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sender == button1) jatekosSorrend.Add(1);
            if (sender == button2) jatekosSorrend.Add(2);
            if (sender == button3) jatekosSorrend.Add(3);
            if (sender == button4) jatekosSorrend.Add(4);
            if (sender == button5) jatekosSorrend.Add(5);
            if (sender == button6) jatekosSorrend.Add(6);
            if (sender == button7) jatekosSorrend.Add(7);
            if (sender == button8) jatekosSorrend.Add(8);
            if (sender == button9) jatekosSorrend.Add(9);
        }
        public void szinezo(int sorszam)
        {
            //adott gombot átszínezi, majd vissza
            if (sorszam == 1) button1.BackColor = button1ColorB;
            if (sorszam == 2) button2.BackColor = button2ColorB;
            if (sorszam == 3) button3.BackColor = button3ColorB;
            if (sorszam == 4) button4.BackColor = button4ColorB;
            if (sorszam == 5) button5.BackColor = button5ColorB;
            if (sorszam == 6) button6.BackColor = button6ColorB;
            if (sorszam == 7) button7.BackColor = button7ColorB;
            if (sorszam == 8) button8.BackColor = button8ColorB;
            if (sorszam == 9) button9.BackColor = button9ColorB;

            Application.DoEvents();
            Thread.Sleep(800);

            button1.BackColor = button1ColorA;
            button2.BackColor = button2ColorA;
            button3.BackColor = button3ColorA;
            button4.BackColor = button4ColorA;
            button5.BackColor = button5ColorA;
            button6.BackColor = button6ColorA;
            button7.BackColor = button7ColorA;
            button8.BackColor = button8ColorA;
            button9.BackColor = button9ColorA;
        }
        
        private void button_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender == button1) button1.BackColor = button1ColorB;
            if (sender == button2) button2.BackColor = button2ColorB;
            if (sender == button3) button3.BackColor = button3ColorB;
            if (sender == button4) button4.BackColor = button4ColorB;
            if (sender == button5) button5.BackColor = button5ColorB;
            if (sender == button6) button6.BackColor = button6ColorB;
            if (sender == button7) button7.BackColor = button7ColorB;
            if (sender == button8) button8.BackColor = button8ColorB;
            if (sender == button9) button9.BackColor = button9ColorB;
        }

        private void button_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender == button1) button1.BackColor = button1ColorA;
            if (sender == button2) button2.BackColor = button2ColorA;
            if (sender == button3) button3.BackColor = button3ColorA;
            if (sender == button4) button4.BackColor = button4ColorA;
            if (sender == button5) button5.BackColor = button5ColorA;
            if (sender == button6) button6.BackColor = button6ColorA;
            if (sender == button7) button7.BackColor = button7ColorA;
            if (sender == button8) button8.BackColor = button8ColorA;
            if (sender == button9) button9.BackColor = button9ColorA;
        }
    }
}
