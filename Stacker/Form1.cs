﻿//Tram Nguyen
// Stacker

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack_Game
{
    public partial class Form1 : Form
    {
        int level = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Game.Start();
            Block1.Hide();
            Block2.Hide();
        }

        //Timer
        private void Timer_Game_Tick(object sender, EventArgs e)
        {
            moveBlock(1);
            if (block.Left > 250)
            {
                Timer_Game.Stop();
                Timer_Game2.Start();
            }
        }

        private void Timer_Game2_Tick(object sender, EventArgs e)
        {
            moveBlock(-1);
            if (block.Left < -5)
            {
                Timer_Game2.Stop();
                Timer_Game.Start();
            }

        }

        private void Timer_Game3_Tick(object sender, EventArgs e)
        {
            if (Block2.Top < Block1.Top)
            {
                Block2.Top += 10;
            }
            else
                Timer_Game3.Stop();
        }

        void moveBlock(int direction)
        {
            block.Left += (30 * direction);
        }

        //Key options for user
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Space)
            {
                level++;
                showBlock(level);
                block.Top -= 20;
                win(level);
                //Timer_Game.Stop();
                //Timer_Game2.Stop();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                Application.Restart();
            }
        }

        void showBlock(int level)
        {
            if (level == 1)
            {
                Block1.Show();
                Block1.Location = block.Location;
            }
            if (level == 2)
            {
                Block2.Show();
                Block2.Location = block.Location;
                if (Block2.Left != Block1.Left)
                {
                    block.Hide();
                    Timer_Game3.Start();
                    fail();
                }

            }
        }

        void fail()
        {
            MessageBox.Show("You Lost!");
            Application.Restart();

        }
        void win(int level)
        {
            if (level == 10)
            {
                MessageBox.Show("You Win!");
            }
        }

    }
}