namespace Snake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            PBgame = new PictureBox();
            label1 = new Label();
            lbScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            lbGameOver = new Label();
            ((System.ComponentModel.ISupportInitialize)PBgame).BeginInit();
            SuspendLayout();
            // 
            // PBgame
            // 
            PBgame.Location = new Point(12, 12);
            PBgame.Name = "PBgame";
            PBgame.Size = new Size(624, 429);
            PBgame.TabIndex = 0;
            PBgame.TabStop = false;
            PBgame.Paint += PBgame_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(642, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Score :";
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Location = new Point(701, 12);
            lbScore.Name = "lbScore";
            lbScore.Size = new Size(50, 20);
            lbScore.TabIndex = 2;
            lbScore.Text = "label2";
            // 
            // lbGameOver
            // 
            lbGameOver.AutoSize = true;
            lbGameOver.Location = new Point(655, 87);
            lbGameOver.Name = "lbGameOver";
            lbGameOver.Size = new Size(40, 20);
            lbGameOver.TabIndex = 3;
            lbGameOver.Text = "Over";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(lbGameOver);
            Controls.Add(lbScore);
            Controls.Add(label1);
            Controls.Add(PBgame);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Snake Game";
            ((System.ComponentModel.ISupportInitialize)PBgame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBgame;
        private Label label1;
        private Label lbScore;
        private System.Windows.Forms.Timer gameTimer;
        private Label lbGameOver;
    }
}