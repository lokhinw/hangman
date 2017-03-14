using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public string guessWord;
        public string buildWord;
        public int stage;
        public Form1()
        {
            InitializeComponent();
        }

        public static string GetRandomWord()
        {
            Random rnd = new Random();
            var lines = File.ReadAllLines("words.txt");

            var lineNumber = rnd.Next(0, lines.Length);

            return lines[lineNumber];
        }

        public void DrawWord()
        {
            label1.Text = "";
            for (int i = 0; i < guessWord.Length; i++)
            {
                label1.Text += buildWord[i] + " ";
            }
        }

        public void GuessLetter(char letter)
        {
            bool check = true;
            for (int i = 0; i < guessWord.Length; i++)
            {
                if (guessWord[i] == letter)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }

            if (!check)
            {
                stage += 1;
            }

            for (int i = 0; i < guessWord.Length; i++)
            {
                if (guessWord[i] == letter)
                {
                    char[] tmp = buildWord.ToCharArray();
                    tmp[i] = letter;
                    buildWord = new string(tmp);
                }
            }
            DrawWord();
            DrawStage();
            CheckWin();
        }
        public void DrawStage()
        {
            if (stage == 1)
            {
                pictureBox1.Image = Properties.Resources._1;
            }
            else if (stage == 2)
            {
                pictureBox1.Image = Properties.Resources._2;
            }
            else if (stage == 3)
            {
                pictureBox1.Image = Properties.Resources._3;
            }
            else if (stage == 4)
            {
                pictureBox1.Image = Properties.Resources._4;
            }
            else if (stage == 5)
            {
                pictureBox1.Image = Properties.Resources._5;
            }
            else if (stage == 6)
            {
                pictureBox1.Image = Properties.Resources._6;
            }
            else if (stage == 7)
            {
                pictureBox1.Image = Properties.Resources._7;
            }
        }
        public void CheckWin()
        {
            if (buildWord == guessWord)
            {
                foreach (Control ctrl in panel1.Controls)
                {
                    ctrl.Enabled = false;
                }
                MessageBox.Show("You Win!");
            }
            else if (stage >= 7)
            {
                foreach (Control ctrl in panel1.Controls)
                {
                    ctrl.Enabled = false;
                }
                MessageBox.Show("You Lose!\nThe Word Was: " + guessWord);
            }
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Enabled = false;
            GuessLetter('z');
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Enabled = false;
            GuessLetter('y');
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            btnX.Enabled = false;
            GuessLetter('x');
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Enabled = false;
            GuessLetter('w');
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Enabled = false;
            GuessLetter('v');

        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Enabled = false;
            GuessLetter('u');
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Enabled = false;
            GuessLetter('t');
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            btnS.Enabled = false;
            GuessLetter('s');
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Enabled = false;
            GuessLetter('r');
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Enabled = false;
            GuessLetter('q');
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Enabled = false;
            GuessLetter('p');
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnO.Enabled = false;
            GuessLetter('o');
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Enabled = false;
            GuessLetter('n');
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Enabled = false;
            GuessLetter('m');
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            btnL.Enabled = false;
            GuessLetter('l');
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            btnK.Enabled = false;
            GuessLetter('k');
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            btnJ.Enabled = false;
            GuessLetter('j');
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            btnI.Enabled = false;
            GuessLetter('i');
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            btnH.Enabled = false;
            GuessLetter('h');
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            btnG.Enabled = false;
            GuessLetter('g');
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            btnF.Enabled = false;
            GuessLetter('f');
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Enabled = false;
            GuessLetter('e');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.Enabled = false;
            GuessLetter('d');
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Enabled = false;
            GuessLetter('c');
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.Enabled = false;
            GuessLetter('b');
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            GuessLetter('a');
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guessWord = GetRandomWord();
            for (int i = 0; i < guessWord.Length; i++)
            {
                buildWord += "_";
            }
            DrawWord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stage = 0;
            pictureBox1.Image = null;
            guessWord = GetRandomWord();
            label1.Text = "";
            buildWord = "";
            for (int i = 0; i < guessWord.Length; i++)
            {
                buildWord += "_";
            }
            DrawWord();
            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.Enabled = true;
            }
        }
    }
}
