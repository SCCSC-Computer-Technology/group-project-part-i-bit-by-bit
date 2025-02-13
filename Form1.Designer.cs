namespace Soccer_Insights
{
    partial class SplashView
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
            this.slideshowBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadProgress = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.slideshowBox)).BeginInit();
            this.SuspendLayout();
            // 
            // slideshowBox
            // 
            this.slideshowBox.BackgroundImage = global::Soccer_Insights.Properties.Resources.FIFA_Players;
            this.slideshowBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.slideshowBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.slideshowBox.Location = new System.Drawing.Point(1, -1);
            this.slideshowBox.Name = "slideshowBox";
            this.slideshowBox.Size = new System.Drawing.Size(425, 449);
            this.slideshowBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slideshowBox.TabIndex = 0;
            this.slideshowBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(457, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "SOCCER INSIGHTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(461, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "You\'re Ultimate Soccer Stats Hub!";
            // 
            // loadProgress
            // 
            this.loadProgress.Location = new System.Drawing.Point(465, 269);
            this.loadProgress.Name = "loadProgress";
            this.loadProgress.Size = new System.Drawing.Size(262, 2);
            this.loadProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadProgress.TabIndex = 3;
            // 
            // SplashView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slideshowBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashView";
            ((System.ComponentModel.ISupportInitialize)(this.slideshowBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slideshowBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar loadProgress;
    }
}

