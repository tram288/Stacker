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
            this.SuspendLayout();
            // 
            // block
            // 
            this.block.BackColor = System.Drawing.Color.Yellow;
            this.block.ForeColor = System.Drawing.Color.Black;
            this.block.Location = new System.Drawing.Point(158, 425);
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
            this.Block2.Location = new System.Drawing.Point(329, 394);
            this.Block2.Name = "Block2";
            this.Block2.Size = new System.Drawing.Size(50, 25);
            this.Block2.TabIndex = 2;
            // 
            // Timer_Game3
            // 
            this.Timer_Game3.Tick += new System.EventHandler(this.Timer_Game3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.Block2);
            this.Controls.Add(this.Block1);
            this.Controls.Add(this.block);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel block;
        private System.Windows.Forms.Timer Timer_Game;
        private System.Windows.Forms.Timer Timer_Game2;
        private System.Windows.Forms.Panel Block1;
        private System.Windows.Forms.Panel Block2;
        private System.Windows.Forms.Timer Timer_Game3;
    }
}

