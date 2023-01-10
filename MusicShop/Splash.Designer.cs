namespace MusicShop
{
    partial class Splash
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
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.loadingPercentage = new System.Windows.Forms.Label();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.loadingPercentage);
            this.guna2GradientPanel1.Controls.Add(this.progressBar);
            this.guna2GradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Crimson;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(600, 300);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // loadingPercentage
            // 
            this.loadingPercentage.AutoSize = true;
            this.loadingPercentage.BackColor = System.Drawing.Color.Transparent;
            this.loadingPercentage.Font = new System.Drawing.Font("MV Boli", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingPercentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loadingPercentage.Location = new System.Drawing.Point(225, 221);
            this.loadingPercentage.Name = "loadingPercentage";
            this.loadingPercentage.Size = new System.Drawing.Size(196, 37);
            this.loadingPercentage.TabIndex = 6;
            this.loadingPercentage.Text = "Loading 99%";
            // 
            // progressBar
            // 
            this.progressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.progressBar.Location = new System.Drawing.Point(2, 287);
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressColor = System.Drawing.Color.Gold;
            this.progressBar.ProgressColor2 = System.Drawing.Color.ForestGreen;
            this.progressBar.Size = new System.Drawing.Size(595, 10);
            this.progressBar.TabIndex = 5;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MusicShop.Properties.Resources.musical_instruments_png_10;
            this.pictureBox1.Location = new System.Drawing.Point(3, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(585, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(107, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Music Instruments Shop";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Shop Management";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label loadingPercentage;
    }
}

