namespace Stack_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.block = new System.Windows.Forms.Panel();
            this.Timer_Game = new System.Windows.Forms.Timer(this.components);
            this.Timer_Game2 = new System.Windows.Forms.Timer(this.components);
            this.Block1 = new System.Windows.Forms.Panel();
            this.Block2 = new System.Windows.Forms.Panel();
            this.Timer_Game3 = new System.Windows.Forms.Timer(this.components);
            this.Block3 = new System.Windows.Forms.Panel();
            this.Block5 = new System.Windows.Forms.Panel();
            this.Block4 = new System.Windows.Forms.Panel();
            this.Block7 = new System.Windows.Forms.Panel();
            this.Block8 = new System.Windows.Forms.Panel();
            this.Block10 = new System.Windows.Forms.Panel();
            this.Block9 = new System.Windows.Forms.Panel();
            this.Block6 = new System.Windows.Forms.Panel();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.YouWinLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Yellow;
            this.block.ForeColor = System.Drawing.Color.Black;
            this.block.Location = new System.Drawing.Point(156, 425);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(50, 25);
            this.block.TabIndex = 0;
            // 
            // Timer_Game
            // 
            this.Timer_Game.Tick += new System.EventHandler(this.Timer_Game_Tick);
            // 
            // Timer_Game2
            // 
            this.Timer_Game2.Tick += new System.EventHandler(this.Timer_Game2_Tick);
            // 
            // Block1
            // 
            this.Block1.BackColor = System.Drawing.Color.Yellow;
            this.Block1.Location = new System.Drawing.Point(329, 425);
            this.Block1.Name = "Block1";
            this.Block1.Size = new System.Drawing.Size(50, 25);
            this.Block1.TabIndex = 1;
            // 
            // Block2
            // 
            this.Block2.BackColor = System.Drawing.Color.Yellow;
            this.Block2.ForeColor = System.Drawing.Color.Red;
            this.Block2.Location = new System.Drawing.Point(329, 394);
            this.Block2.Name = "Block2";
            this.Block2.Size = new System.Drawing.Size(50, 25);
            this.Block2.TabIndex = 2;
            // 
            // Timer_Game3
            // 
            this.Timer_Game3.Tick += new System.EventHandler(this.Timer_Game3_Tick);
            // 
            // Block3
            // 
            this.Block3.BackColor = System.Drawing.Color.Yellow;
            this.Block3.ForeColor = System.Drawing.Color.Red;
            this.Block3.Location = new System.Drawing.Point(329, 363);
            this.Block3.Name = "Block3";
            this.Block3.Size = new System.Drawing.Size(50, 25);
            this.Block3.TabIndex = 3;
            // 
            // Block5
            // 
            this.Block5.BackColor = System.Drawing.Color.Yellow;
            this.Block5.ForeColor = System.Drawing.Color.Red;
            this.Block5.Location = new System.Drawing.Point(329, 301);
            this.Block5.Name = "Block5";
            this.Block5.Size = new System.Drawing.Size(50, 25);
            this.Block5.TabIndex = 4;
            // 
            // Block4
            // 
            this.Block4.BackColor = System.Drawing.Color.Yellow;
            this.Block4.ForeColor = System.Drawing.Color.Red;
            this.Block4.Location = new System.Drawing.Point(329, 332);
            this.Block4.Name = "Block4";
            this.Block4.Size = new System.Drawing.Size(50, 25);
            this.Block4.TabIndex = 3;
            // 
            // Block7
            // 
            this.Block7.BackColor = System.Drawing.Color.Yellow;
            this.Block7.ForeColor = System.Drawing.Color.Red;
            this.Block7.Location = new System.Drawing.Point(329, 239);
            this.Block7.Name = "Block7";
            this.Block7.Size = new System.Drawing.Size(50, 25);
            this.Block7.TabIndex = 5;
            // 
            // Block8
            // 
            this.Block8.BackColor = System.Drawing.Color.Yellow;
            this.Block8.ForeColor = System.Drawing.Color.Red;
            this.Block8.Location = new System.Drawing.Point(329, 208);
            this.Block8.Name = "Block8";
            this.Block8.Size = new System.Drawing.Size(50, 25);
            this.Block8.TabIndex = 3;
            // 
            // Block10
            // 
            this.Block10.BackColor = System.Drawing.Color.Yellow;
            this.Block10.ForeColor = System.Drawing.Color.Red;
            this.Block10.Location = new System.Drawing.Point(329, 146);
            this.Block10.Name = "Block10";
            this.Block10.Size = new System.Drawing.Size(50, 25);
            this.Block10.TabIndex = 3;
            // 
            // Block9
            // 
            this.Block9.BackColor = System.Drawing.Color.Yellow;
            this.Block9.ForeColor = System.Drawing.Color.Red;
            this.Block9.Location = new System.Drawing.Point(329, 177);
            this.Block9.Name = "Block9";
            this.Block9.Size = new System.Drawing.Size(50, 25);
            this.Block9.TabIndex = 3;
            // 
            // Block6
            // 
            this.Block6.BackColor = System.Drawing.Color.Yellow;
            this.Block6.ForeColor = System.Drawing.Color.Red;
            this.Block6.Location = new System.Drawing.Point(329, 270);
            this.Block6.Name = "Block6";
            this.Block6.Size = new System.Drawing.Size(50, 25);
            this.Block6.TabIndex = 3;
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.White;
            this.GameOverLabel.Location = new System.Drawing.Point(116, 79);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(145, 29);
            this.GameOverLabel.TabIndex = 6;
            this.GameOverLabel.Text = "Game Over";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YouWinLabel
            // 
            this.YouWinLabel.AutoSize = true;
            this.YouWinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YouWinLabel.ForeColor = System.Drawing.Color.White;
            this.YouWinLabel.Location = new System.Drawing.Point(135, 79);
            this.YouWinLabel.Name = "YouWinLabel";
            this.YouWinLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.YouWinLabel.Size = new System.Drawing.Size(110, 29);
            this.YouWinLabel.TabIndex = 7;
            this.YouWinLabel.Text = "You Win";
            this.YouWinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.YouWinLabel);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.Block10);
            this.Controls.Add(this.Block9);
            this.Controls.Add(this.Block8);
            this.Controls.Add(this.Block6);
            this.Controls.Add(this.Block7);
            this.Controls.Add(this.Block4);
            this.Controls.Add(this.Block5);
            this.Controls.Add(this.Block3);
            this.Controls.Add(this.Block2);
            this.Controls.Add(this.Block1);
            this.Controls.Add(this.block);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel block;
        private System.Windows.Forms.Timer Timer_Game;
        private System.Windows.Forms.Timer Timer_Game2;
        private System.Windows.Forms.Panel Block1;
        private System.Windows.Forms.Panel Block2;
        private System.Windows.Forms.Timer Timer_Game3;
        private System.Windows.Forms.Panel Block3;
        private System.Windows.Forms.Panel Block5;
        private System.Windows.Forms.Panel Block4;
        private System.Windows.Forms.Panel Block7;
        private System.Windows.Forms.Panel Block8;
        private System.Windows.Forms.Panel Block10;
        private System.Windows.Forms.Panel Block9;
        private System.Windows.Forms.Panel Block6;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label YouWinLabel;
    }
}

