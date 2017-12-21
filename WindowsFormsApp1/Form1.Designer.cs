namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Card1
            // 
            this.Card1.Image = ((System.Drawing.Image)(resources.GetObject("Card1.Image")));
            this.Card1.Location = new System.Drawing.Point(226, 580);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(271, 417);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 1;
            this.Card1.TabStop = false;
            // 
            // Card2
            // 
            this.Card2.Image = ((System.Drawing.Image)(resources.GetObject("Card2.Image")));
            this.Card2.Location = new System.Drawing.Point(503, 580);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(271, 417);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 2;
            this.Card2.TabStop = false;
            // 
            // Card3
            // 
            this.Card3.Image = ((System.Drawing.Image)(resources.GetObject("Card3.Image")));
            this.Card3.Location = new System.Drawing.Point(780, 580);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(271, 417);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 3;
            this.Card3.TabStop = false;
            this.Card3.Visible = false;
            // 
            // Card4
            // 
            this.Card4.Image = ((System.Drawing.Image)(resources.GetObject("Card4.Image")));
            this.Card4.Location = new System.Drawing.Point(1057, 580);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(271, 417);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 4;
            this.Card4.TabStop = false;
            this.Card4.Visible = false;
            // 
            // Card5
            // 
            this.Card5.Image = ((System.Drawing.Image)(resources.GetObject("Card5.Image")));
            this.Card5.Location = new System.Drawing.Point(1334, 580);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(271, 417);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 5;
            this.Card5.TabStop = false;
            this.Card5.Visible = false;
            // 
            // Card6
            // 
            this.Card6.Image = ((System.Drawing.Image)(resources.GetObject("Card6.Image")));
            this.Card6.Location = new System.Drawing.Point(1611, 580);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(271, 417);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 6;
            this.Card6.TabStop = false;
            this.Card6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(629, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 98);
            this.label1.TabIndex = 7;
            this.label1.Text = "Score:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(867, 375);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(86, 98);
            this.ScoreLabel.TabIndex = 8;
            this.ScoreLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Card6);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.PictureBox Card1;
        protected System.Windows.Forms.PictureBox Card2;
        protected System.Windows.Forms.PictureBox Card3;
        protected System.Windows.Forms.PictureBox Card4;
        protected System.Windows.Forms.PictureBox Card5;
        protected System.Windows.Forms.PictureBox Card6;
        protected System.Windows.Forms.Label ScoreLabel;
    }
}

