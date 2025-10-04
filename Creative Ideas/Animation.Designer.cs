namespace Creative_Ideas
{
    partial class Animation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animation));
            this.Animationplayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Animationplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Animationplayer
            // 
            this.Animationplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Animationplayer.Enabled = true;
            this.Animationplayer.Location = new System.Drawing.Point(0, 0);
            this.Animationplayer.Name = "Animationplayer";
            this.Animationplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Animationplayer.OcxState")));
            this.Animationplayer.Size = new System.Drawing.Size(284, 263);
            this.Animationplayer.TabIndex = 0;
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.Animationplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Animation";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Animation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Animationplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Animationplayer;
    }
}