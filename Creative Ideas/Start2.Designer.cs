namespace Creative_Ideas
{
    partial class Start2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start2));
            this.Start2player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btntat = new System.Windows.Forms.Button();
            this.btnsn = new System.Windows.Forms.Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.lbls2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Start2player)).BeginInit();
            this.SuspendLayout();
            // 
            // Start2player
            // 
            this.Start2player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Start2player.Enabled = true;
            this.Start2player.Location = new System.Drawing.Point(0, 0);
            this.Start2player.Name = "Start2player";
            this.Start2player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Start2player.OcxState")));
            this.Start2player.Size = new System.Drawing.Size(1087, 719);
            this.Start2player.TabIndex = 3;
            this.Start2player.Enter += new System.EventHandler(this.Start2player_Enter);
            // 
            // btntat
            // 
            this.btntat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btntat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntat.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntat.Location = new System.Drawing.Point(145, 283);
            this.btntat.Name = "btntat";
            this.btntat.Size = new System.Drawing.Size(300, 200);
            this.btntat.TabIndex = 1;
            this.btntat.Text = "Take a tour!";
            this.btntat.UseVisualStyleBackColor = false;
            this.btntat.Click += new System.EventHandler(this.btntat_Click);
            this.btntat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btntat_KeyDown);
            this.btntat.MouseLeave += new System.EventHandler(this.btntat_MouseLeave);
            this.btntat.MouseHover += new System.EventHandler(this.btntat_MouseHover);
            this.btntat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btntat_MouseMove);
            // 
            // btnsn
            // 
            this.btnsn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnsn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnsn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsn.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsn.Location = new System.Drawing.Point(604, 283);
            this.btnsn.Name = "btnsn";
            this.btnsn.Size = new System.Drawing.Size(300, 200);
            this.btnsn.TabIndex = 2;
            this.btnsn.Text = "Start Now!";
            this.btnsn.UseVisualStyleBackColor = false;
            this.btnsn.Click += new System.EventHandler(this.btnsn_Click);
            this.btnsn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsn_KeyDown);
            this.btnsn.MouseLeave += new System.EventHandler(this.btnsn_MouseLeave);
            this.btnsn.MouseHover += new System.EventHandler(this.btnsn_MouseHover);
            // 
            // lblwelcome
            // 
            this.lblwelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblwelcome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblwelcome.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(338, 87);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(389, 117);
            this.lblwelcome.TabIndex = 4;
            this.lblwelcome.Text = "Welcome!";
            // 
            // lbls2
            // 
            this.lbls2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbls2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbls2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbls2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbls2.Location = new System.Drawing.Point(252, 543);
            this.lbls2.Name = "lbls2";
            this.lbls2.Size = new System.Drawing.Size(555, 167);
            this.lbls2.TabIndex = 5;
            this.lbls2.Text = "  From MacGyver to MickeyMouse,  we believe in the power of creativity and its wi" +
    "de-reaching nature";
            this.lbls2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 719);
            this.Controls.Add(this.lbls2);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.btnsn);
            this.Controls.Add(this.btntat);
            this.Controls.Add(this.Start2player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start2";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Start2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Start2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Start2player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Start2player;
        private System.Windows.Forms.Button btntat;
        private System.Windows.Forms.Button btnsn;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label lbls2;
    }
}