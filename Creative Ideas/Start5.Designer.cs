namespace Creative_Ideas
{
    partial class Start5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start5));
            this.Start5player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbls5 = new System.Windows.Forms.Label();
            this.btnF = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.lblGOS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Start5player)).BeginInit();
            this.SuspendLayout();
            // 
            // Start5player
            // 
            this.Start5player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start5player.Enabled = true;
            this.Start5player.Location = new System.Drawing.Point(0, 0);
            this.Start5player.Name = "Start5player";
            this.Start5player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Start5player.OcxState")));
            this.Start5player.Size = new System.Drawing.Size(1155, 729);
            this.Start5player.TabIndex = 5;
            // 
            // lbls5
            // 
            this.lbls5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbls5.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbls5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbls5.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls5.ForeColor = System.Drawing.Color.Blue;
            this.lbls5.Location = new System.Drawing.Point(537, 568);
            this.lbls5.Name = "lbls5";
            this.lbls5.Size = new System.Drawing.Size(499, 106);
            this.lbls5.TabIndex = 4;
            this.lbls5.Text = "Experience the full functions of the software";
            this.lbls5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnF
            // 
            this.btnF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnF.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.ForeColor = System.Drawing.Color.Blue;
            this.btnF.Location = new System.Drawing.Point(117, 398);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(300, 110);
            this.btnF.TabIndex = 2;
            this.btnF.Text = "Yes,Finally!";
            this.btnF.UseVisualStyleBackColor = false;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            this.btnF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnF_KeyDown);
            this.btnF.MouseLeave += new System.EventHandler(this.btnF_MouseLeave);
            this.btnF.MouseHover += new System.EventHandler(this.btnF_MouseHover);
            // 
            // btnNE
            // 
            this.btnNE.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNE.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNE.ForeColor = System.Drawing.Color.Blue;
            this.btnNE.Location = new System.Drawing.Point(537, 398);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(499, 110);
            this.btnNE.TabIndex = 3;
            this.btnNE.Text = "Not Exactly";
            this.btnNE.UseVisualStyleBackColor = false;
            this.btnNE.Click += new System.EventHandler(this.btnNE_Click);
            this.btnNE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNE_KeyDown);
            this.btnNE.MouseLeave += new System.EventHandler(this.btnNE_MouseLeave);
            this.btnNE.MouseHover += new System.EventHandler(this.btnNE_MouseHover);
            // 
            // lblGOS
            // 
            this.lblGOS.AllowDrop = true;
            this.lblGOS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGOS.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblGOS.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGOS.ForeColor = System.Drawing.Color.Blue;
            this.lblGOS.Location = new System.Drawing.Point(215, 77);
            this.lblGOS.Name = "lblGOS";
            this.lblGOS.Size = new System.Drawing.Size(709, 247);
            this.lblGOS.TabIndex = 1;
            this.lblGOS.Text = "Generate your own           story";
            // 
            // Start5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 729);
            this.Controls.Add(this.lbls5);
            this.Controls.Add(this.lblGOS);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnF);
            this.Controls.Add(this.Start5player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start5";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Start5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Start5player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Start5player;
        private System.Windows.Forms.Label lbls5;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Label lblGOS;
    }
}