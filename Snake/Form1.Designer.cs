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
            CountS = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            GameOverUI = new Label();
            ((System.ComponentModel.ISupportInitialize)PBgame).BeginInit();
            SuspendLayout();
            // 
            // PBgame
            // 
            PBgame.Location = new Point(12, 12);
            PBgame.Name = "PBgame";
            PBgame.Size = new Size(645, 435);
            PBgame.TabIndex = 0;
            PBgame.TabStop = false;
            PBgame.Paint += PBgame_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(666, 12);
            label1.Name = "label1";
            label1.Size = new Size(104, 38);
            label1.TabIndex = 1;
            label1.Text = "SCORE";
            // 
            // CountS
            // 
            CountS.AutoSize = true;
            CountS.Location = new Point(690, 65);
            CountS.Name = "CountS";
            CountS.Size = new Size(50, 20);
            CountS.TabIndex = 2;
            CountS.Text = "label2";
            // 
            // GameOverUI
            // 
            GameOverUI.AutoSize = true;
            GameOverUI.Location = new Point(690, 126);
            GameOverUI.Name = "GameOverUI";
            GameOverUI.Size = new Size(50, 20);
            GameOverUI.TabIndex = 3;
            GameOverUI.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(GameOverUI);
            Controls.Add(CountS);
            Controls.Add(label1);
            Controls.Add(PBgame);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Snake What ?";
            ((System.ComponentModel.ISupportInitialize)PBgame).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBgame;
        private Label label1;
        private Label CountS;
        private System.Windows.Forms.Timer gameTimer;
        private Label GameOverUI;
    }
}