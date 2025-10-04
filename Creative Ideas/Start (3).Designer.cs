namespace Creative_Ideas
{
    partial class Start3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start3));
            this.Start3videoplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lblTI = new System.Windows.Forms.Label();
            this.btnNope = new System.Windows.Forms.Button();
            this.btnLS = new System.Windows.Forms.Button();
            this.lbls3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Start3videoplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Start3videoplayer
            // 
            this.Start3videoplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start3videoplayer.Enabled = true;
            this.Start3videoplayer.Location = new System.Drawing.Point(0, 0);
            this.Start3videoplayer.Name = "Start3videoplayer";
            this.Start3videoplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Start3videoplayer.OcxState")));
            this.Start3videoplayer.Size = new System.Drawing.Size(886, 635);
            this.Start3videoplayer.TabIndex = 5;
            // 
            // lblTI
            // 
            this.lblTI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTI.AutoSize = true;
            this.lblTI.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblTI.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTI.ForeColor = System.Drawing.Color.Red;
            this.lblTI.Location = new System.Drawing.Point(271, 99);
            this.lblTI.Name = "lblTI";
            this.lblTI.Size = new System.Drawing.Size(373, 117);
            this.lblTI.TabIndex = 4;
            this.lblTI.Text = "Think It!";
            // 
            // btnNope
            // 
            this.btnNope.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNope.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNope.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNope.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNope.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNope.ForeColor = System.Drawing.Color.Red;
            this.btnNope.Location = new System.Drawing.Point(525, 497);
            this.btnNope.Name = "btnNope";
            this.btnNope.Size = new System.Drawing.Size(300, 112);
            this.btnNope.TabIndex = 2;
            this.btnNope.Text = "Nope!";
            this.btnNope.UseVisualStyleBackColor = false;
            this.btnNope.Click += new System.EventHandler(this.btnNope_Click);
            this.btnNope.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNope_KeyDown);
            this.btnNope.MouseLeave += new System.EventHandler(this.btnNope_MouseLeave);
            this.btnNope.MouseHover += new System.EventHandler(this.btnNope_MouseHover);
            // 
            // btnLS
            // 
            this.btnLS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLS.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLS.ForeColor = System.Drawing.Color.Red;
            this.btnLS.Location = new System.Drawing.Point(84, 497);
            this.btnLS.Name = "btnLS";
            this.btnLS.Size = new System.Drawing.Size(300, 110);
            this.btnLS.TabIndex = 1;
            this.btnLS.Text = "Let\'s see!";
            this.btnLS.UseVisualStyleBackColor = false;
            this.btnLS.Click += new System.EventHandler(this.btnLS_Click);
            this.btnLS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLS_KeyDown);
            this.btnLS.MouseLeave += new System.EventHandler(this.btnLS_MouseLeave);
            this.btnLS.MouseHover += new System.EventHandler(this.btnLS_MouseHover);
            // 
            // lbls3
            // 
            this.lbls3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbls3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbls3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbls3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls3.ForeColor = System.Drawing.Color.Red;
            this.lbls3.Location = new System.Drawing.Point(186, 287);
            this.lbls3.Name = "lbls3";
            this.lbls3.Size = new System.Drawing.Size(555, 141);
            this.lbls3.TabIndex = 3;
            this.lbls3.Text = "Be fascinated by our already included stories and edit them as desire";
            this.lbls3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbls3.Click += new System.EventHandler(this.lbls3_Click);
            // 
            // Start3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 635);
            this.Controls.Add(this.lbls3);
            this.Controls.Add(this.lblTI);
            this.Controls.Add(this.btnNope);
            this.Controls.Add(this.btnLS);
            this.Controls.Add(this.Start3videoplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start3";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Start3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Start3videoplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Start3videoplayer;
        private System.Windows.Forms.Label lblTI;
        private System.Windows.Forms.Button btnNope;
        private System.Windows.Forms.Button btnLS;
        private System.Windows.Forms.Label lbls3;
    }
}