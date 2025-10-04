namespace Creative_Ideas
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.StartVideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btndummy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartVideoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // StartVideoPlayer
            // 
            this.StartVideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartVideoPlayer.Enabled = true;
            this.StartVideoPlayer.Location = new System.Drawing.Point(0, 0);
            this.StartVideoPlayer.Name = "StartVideoPlayer";
            this.StartVideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("StartVideoPlayer.OcxState")));
            this.StartVideoPlayer.Size = new System.Drawing.Size(1089, 593);
            this.StartVideoPlayer.TabIndex = 2;
            this.StartVideoPlayer.Enter += new System.EventHandler(this.StartVideoPlayer_Enter);
            // 
            // btndummy
            // 
            this.btndummy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndummy.BackColor = System.Drawing.Color.White;
            this.btndummy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndummy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndummy.Location = new System.Drawing.Point(117, 328);
            this.btndummy.Name = "btndummy";
            this.btndummy.Size = new System.Drawing.Size(17, 19);
            this.btndummy.TabIndex = 1;
            this.btndummy.UseVisualStyleBackColor = true;
            this.btndummy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btndummy_KeyDown);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 593);
            this.Controls.Add(this.btndummy);
            this.Controls.Add(this.StartVideoPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Start_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.StartVideoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer StartVideoPlayer;
        private System.Windows.Forms.Button btndummy;
    }
}