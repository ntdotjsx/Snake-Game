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
            PBgame = new PictureBox();
            label1 = new Label();
            label2 = new Label();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(701, 12);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(label2);
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
        private Label label2;
    }
}