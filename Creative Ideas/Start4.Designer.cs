namespace Creative_Ideas
{
    partial class Start4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start4));
            this.Start4player = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbls4 = new System.Windows.Forms.Label();
            this.lblSI = new System.Windows.Forms.Label();
            this.btnNML = new System.Windows.Forms.Button();
            this.btnDIN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Start4player)).BeginInit();
            this.SuspendLayout();
            // 
            // Start4player
            // 
            this.Start4player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Start4player.Enabled = true;
            this.Start4player.Location = new System.Drawing.Point(0, 0);
            this.Start4player.Name = "Start4player";
            this.Start4player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Start4player.OcxState")));
            this.Start4player.Size = new System.Drawing.Size(971, 659);
            this.Start4player.TabIndex = 5;
            this.Start4player.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.Start4player_KeyDownEvent);
            // 
            // lbls4
            // 
            this.lbls4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbls4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbls4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbls4.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls4.ForeColor = System.Drawing.Color.Lime;
            this.lbls4.Location = new System.Drawing.Point(218, 241);
            this.lbls4.Name = "lbls4";
            this.lbls4.Size = new System.Drawing.Size(542, 167);
            this.lbls4.TabIndex = 3;
            this.lbls4.Text = "Make a quick sketch or brush notes about your ideas";
            this.lbls4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSI
            // 
            this.lblSI.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSI.AutoSize = true;
            this.lblSI.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblSI.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSI.ForeColor = System.Drawing.Color.Lime;
            this.lblSI.Location = new System.Drawing.Point(303, 68);
            this.lblSI.Name = "lblSI";
            this.lblSI.Size = new System.Drawing.Size(400, 117);
            this.lblSI.TabIndex = 4;
            this.lblSI.Text = "Sketch It!";
            this.lblSI.Click += new System.EventHandler(this.lblSI_Click);
            // 
            // btnNML
            // 
            this.btnNML.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnNML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNML.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNML.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNML.ForeColor = System.Drawing.Color.Lime;
            this.btnNML.Location = new System.Drawing.Point(477, 472);
            this.btnNML.Name = "btnNML";
            this.btnNML.Size = new System.Drawing.Size(417, 110);
            this.btnNML.TabIndex = 2;
            this.btnNML.Text = "Nah,Maybe Later!";
            this.btnNML.UseVisualStyleBackColor = false;
            this.btnNML.Click += new System.EventHandler(this.btnNML_Click);
            this.btnNML.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnNML_KeyDown);
            this.btnNML.MouseLeave += new System.EventHandler(this.btnNML_MouseLeave);
            this.btnNML.MouseHover += new System.EventHandler(this.btnNML_MouseHover);
            // 
            // btnDIN
            // 
            this.btnDIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDIN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDIN.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIN.ForeColor = System.Drawing.Color.Lime;
            this.btnDIN.Location = new System.Drawing.Point(86, 472);
            this.btnDIN.Name = "btnDIN";
            this.btnDIN.Size = new System.Drawing.Size(300, 110);
            this.btnDIN.TabIndex = 1;
            this.btnDIN.Text = "Do It Now!";
            this.btnDIN.UseVisualStyleBackColor = false;
            this.btnDIN.Click += new System.EventHandler(this.btnDIN_Click);
            this.btnDIN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDIN_KeyDown);
            this.btnDIN.MouseLeave += new System.EventHandler(this.btnDIN_MouseLeave);
            this.btnDIN.MouseHover += new System.EventHandler(this.btnDIN_MouseHover);
            // 
            // Start4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 659);
            this.Controls.Add(this.lbls4);
            this.Controls.Add(this.lblSI);
            this.Controls.Add(this.btnNML);
            this.Controls.Add(this.btnDIN);
            this.Controls.Add(this.Start4player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start4";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Start4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Start4player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Start4player;
        private System.Windows.Forms.Label lbls4;
        private System.Windows.Forms.Label lblSI;
        private System.Windows.Forms.Button btnNML;
        private System.Windows.Forms.Button btnDIN;
    }
}