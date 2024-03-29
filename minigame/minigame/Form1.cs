﻿using System;
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
        //sound files
        SoundPlayer correctSound = new SoundPlayer("sound/correct2.wav");
        SoundPlayer gameOverSound = new SoundPlayer("sound/wrong.wav");

        //buttons default colors
        public static Color button1ColorA = Color.Red;
        public static Color button2ColorA = Color.Orange;
        public static Color button3ColorA = Color.Yellow;
        public static Color button4ColorA = Color.Lime;
        public static Color button5ColorA = Color.Aqua;
        public static Color button6ColorA = Color.Blue;
        public static Color button7ColorA = Color.Fuchsia;
        public static Color button8ColorA = Color.FromArgb(64, 64, 64);
        public static Color button9ColorA = Color.White;

        //buttons pressed colors
        public static Color button1ColorB = Color.FromArgb(255, 192, 192);
        public static Color button2ColorB = Color.FromArgb(255, 224, 192);
        public static Color button3ColorB = Color.FromArgb(255, 255, 192);
        public static Color button4ColorB = Color.FromArgb(192, 255, 192);
        public static Color button5ColorB = Color.FromArgb(192, 255, 255);
        public static Color button6ColorB = Color.FromArgb(192, 192, 255);
        public static Color button7ColorB = Color.FromArgb(255, 192, 255);
        public static Color button8ColorB = Color.Gray;
        public static Color button9ColorB = Color.DarkGray;

        
        List<int> generatedSequence = new List<int>() { };
        List<int> playerSequence = new List<int>() { };

        int roundCounter = 0;
        int firstRound = 1;
        int timeBeforeRoundStart = 500;
        int timeBetweenButtonFlashes = 400;
        int changedButtonColorDuration = 800;
        string gameOverText = "Wrong! Game over!";


        public Form1()
        {
            InitializeComponent();
        }


        private void new_game_Click(object sender, EventArgs e)
        {
            generatedSequence = new List<int>();
            playerSequence = new List<int>();
            roundCounter = firstRound;
            roundValue.Text = roundCounter.ToString();
            NextRound();
        }


        public void NextRound()
        {
            Thread.Sleep(timeBeforeRoundStart);
            Random randomNumber = new Random();
            generatedSequence.Add(randomNumber.Next(1, 10));

            foreach (var button in generatedSequence)
            {
                ChangeColor(button);

                Application.DoEvents();
                Thread.Sleep(timeBetweenButtonFlashes);
            }
            playerSequence = new List<int>();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (IsItCorrect())
            {
                correctSound.Play();
                roundCounter++;
                roundValue.Text = roundCounter.ToString();
                NextRound();
            }

            else if (int.Parse(highScoreValue.Text) < roundCounter - 1)
            {
                highScoreValue.Text = (roundCounter - 1).ToString();
            }
        }


        public bool  IsItCorrect()
        {
            if (generatedSequence.SequenceEqual(playerSequence))
            {
                return true;
            }
            else
            {
                gameOverSound.Play();
                MessageBox.Show(gameOverText);
                return false;
            }
        }



        private void button_Click(object sender, EventArgs e)
        {
            if (sender == button1) playerSequence.Add(1);
            if (sender == button2) playerSequence.Add(2);
            if (sender == button3) playerSequence.Add(3);
            if (sender == button4) playerSequence.Add(4);
            if (sender == button5) playerSequence.Add(5);
            if (sender == button6) playerSequence.Add(6);
            if (sender == button7) playerSequence.Add(7);
            if (sender == button8) playerSequence.Add(8);
            if (sender == button9) playerSequence.Add(9);
        }


        public void ChangeColor(int number)
        {
            //changing the color
            if (number == 1) button1.BackColor = button1ColorB;
            if (number == 2) button2.BackColor = button2ColorB;
            if (number == 3) button3.BackColor = button3ColorB;
            if (number == 4) button4.BackColor = button4ColorB;
            if (number == 5) button5.BackColor = button5ColorB;
            if (number == 6) button6.BackColor = button6ColorB;
            if (number == 7) button7.BackColor = button7ColorB;
            if (number == 8) button8.BackColor = button8ColorB;
            if (number == 9) button9.BackColor = button9ColorB;

            Application.DoEvents();
            Thread.Sleep(changedButtonColorDuration);

            //changing it back
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
