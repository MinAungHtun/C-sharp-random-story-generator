namespace Creative_Ideas
{
    partial class Script1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Script1));
            this.ScriptPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnGTF = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tbxs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // ScriptPlayer
            // 
            this.ScriptPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScriptPlayer.Enabled = true;
            this.ScriptPlayer.Location = new System.Drawing.Point(0, 0);
            this.ScriptPlayer.Name = "ScriptPlayer";
            this.ScriptPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("ScriptPlayer.OcxState")));
            this.ScriptPlayer.Size = new System.Drawing.Size(981, 620);
            this.ScriptPlayer.TabIndex = 5;
            // 
            // btnGTF
            // 
            this.btnGTF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGTF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGTF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGTF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGTF.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGTF.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnGTF.Location = new System.Drawing.Point(727, 505);
            this.btnGTF.Name = "btnGTF";
            this.btnGTF.Size = new System.Drawing.Size(119, 47);
            this.btnGTF.TabIndex = 3;
            this.btnGTF.Text = "Go to full";
            this.btnGTF.UseVisualStyleBackColor = false;
            this.btnGTF.Click += new System.EventHandler(this.btnGTF_Click);
            this.btnGTF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGTF_KeyDown);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Gray;
            this.btncancel.Location = new System.Drawing.Point(446, 505);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(117, 47);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Clear";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            this.btncancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btncancel_KeyDown);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(178, 505);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(119, 47);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsave_KeyDown);
            // 
            // tbxs
            // 
            this.tbxs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbxs.BackColor = System.Drawing.Color.White;
            this.tbxs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxs.Location = new System.Drawing.Point(94, 87);
            this.tbxs.Multiline = true;
            this.tbxs.Name = "tbxs";
            this.tbxs.Size = new System.Drawing.Size(820, 341);
            this.tbxs.TabIndex = 4;
            this.tbxs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxs_KeyDown);
            // 
            // Script1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 620);
            this.Controls.Add(this.btnGTF);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tbxs);
            this.Controls.Add(this.ScriptPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Script1";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Script1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScriptPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer ScriptPlayer;
        private System.Windows.Forms.Button btnGTF;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox tbxs;
    }
}