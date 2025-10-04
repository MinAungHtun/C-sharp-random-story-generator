namespace Creative_Ideas
{
    partial class Generator1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator1));
            this.Genplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnGTF = new System.Windows.Forms.Button();
            this.btnGRS = new System.Windows.Forms.Button();
            this.tbxS = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Genplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // Genplayer
            // 
            this.Genplayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Genplayer.Enabled = true;
            this.Genplayer.Location = new System.Drawing.Point(0, 0);
            this.Genplayer.Name = "Genplayer";
            this.Genplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Genplayer.OcxState")));
            this.Genplayer.Size = new System.Drawing.Size(966, 572);
            this.Genplayer.TabIndex = 4;
            // 
            // btnGTF
            // 
            this.btnGTF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGTF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGTF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGTF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGTF.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTF.Location = new System.Drawing.Point(702, 459);
            this.btnGTF.Name = "btnGTF";
            this.btnGTF.Size = new System.Drawing.Size(222, 78);
            this.btnGTF.TabIndex = 4;
            this.btnGTF.Text = "Go to full";
            this.btnGTF.UseVisualStyleBackColor = false;
            this.btnGTF.Click += new System.EventHandler(this.btnGTF_Click);
            this.btnGTF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGTF_KeyDown);
            this.btnGTF.MouseLeave += new System.EventHandler(this.btnGTF_MouseLeave);
            this.btnGTF.MouseHover += new System.EventHandler(this.btnGTF_MouseHover);
            // 
            // btnGRS
            // 
            this.btnGRS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGRS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGRS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGRS.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRS.ForeColor = System.Drawing.Color.Lime;
            this.btnGRS.Location = new System.Drawing.Point(273, 38);
            this.btnGRS.Name = "btnGRS";
            this.btnGRS.Size = new System.Drawing.Size(372, 90);
            this.btnGRS.TabIndex = 1;
            this.btnGRS.Text = "Generate Random Story";
            this.btnGRS.UseVisualStyleBackColor = false;
            this.btnGRS.Click += new System.EventHandler(this.btnGRS_Click);
            this.btnGRS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGRS_KeyDown);
            this.btnGRS.MouseLeave += new System.EventHandler(this.btnGRS_MouseLeave);
            this.btnGRS.MouseHover += new System.EventHandler(this.btnGRS_MouseHover);
            // 
            // tbxS
            // 
            this.tbxS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxS.BackColor = System.Drawing.Color.White;
            this.tbxS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxS.Location = new System.Drawing.Point(113, 149);
            this.tbxS.Multiline = true;
            this.tbxS.Name = "tbxS";
            this.tbxS.Size = new System.Drawing.Size(702, 287);
            this.tbxS.TabIndex = 5;
            this.tbxS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxS_KeyDown);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(58, 459);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(841, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // Generator1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGTF);
            this.Controls.Add(this.btnGRS);
            this.Controls.Add(this.tbxS);
            this.Controls.Add(this.Genplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generator1";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Generator1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Genplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Genplayer;
        private System.Windows.Forms.Button btnGTF;
        private System.Windows.Forms.Button btnGRS;
        private System.Windows.Forms.TextBox tbxS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}