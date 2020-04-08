//Tram Nguyen
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
        int speedLevel = 3;
        int maxSpeedLevel = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer_Game.Start();
            Block1.Hide();
            Block2.Hide();
            Block3.Hide();
            Block4.Hide();
            Block5.Hide();
            Block6.Hide();
            Block7.Hide();
            Block8.Hide();
            Block9.Hide();
            Block10.Hide();

            YouWinLabel.Hide();
            GameOverLabel.Hide();
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
            switch (level)
            {
                case 2:
                    if (Block2.Top < Block1.Top)
                    {
                        Block2.Top += 10;
                    }
                    else
                        Timer_Game3.Stop();
                    break;
                case 3:
                    if (Block3.Top < Block1.Top)
                    {
                        Block3.Top += 10;
                    }
                    else
                        Timer_Game3.Stop();
                    break;
            }
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
                if (level == speedLevel)
                {
                    Timer_Game.Interval = 50;
                    Timer_Game2.Interval = 50;
                }
                if (level == maxSpeedLevel)
                {
                    Timer_Game.Interval = 30;
                    Timer_Game2.Interval = 30;
                }
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                Application.Restart();
            }
        }

        //Block Action
        void moveBlock(int direction)
        {
            block.Left += (30 * direction);
        }

        void showBlock(int level)
        {
            switch (level)
            {
                case 1:
                    Block1.Show();
                    Block1.Location = block.Location;
                    break;
                case 2:
                    Block2.Show();
                    Block2.Location = block.Location;
                    if (Block2.Left != Block1.Left)
                    {
                        block.Hide();
                        Timer_Game3.Start();
                        fail();           
                    }
                    break;
                case 3:
                    Block3.Show();
                    Block3.Location = block.Location;
                    if (Block3.Left != Block2.Left)
                    {
                        block.Hide();
                        Timer_Game3.Start();
                        fail();                     
                    }
                    break;
            }

        }

        //Option Manager
        void fail()
        {
            GameOverLabel.Show();
            //Application.Restart();
        }
        void win(int level)
        {
            if (level == 10)
            {
                YouWinLabel.Show();
                HideBlock();
            }
        }

        void HideBlock()
        {
            block.Hide();
            Block1.Hide();
            Block2.Hide();
            Block3.Hide();
            Block4.Hide();
            Block5.Hide();
            Block6.Hide();
            Block7.Hide();
            Block8.Hide();
            Block9.Hide();
            Block10.Hide();
        }
    }
}
