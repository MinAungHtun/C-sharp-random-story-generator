namespace Creative_Ideas
{
    partial class Sketch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sketch));
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lblplus = new System.Windows.Forms.Label();
            this.pnlacc = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btneraser = new System.Windows.Forms.Button();
            this.btnGTF = new System.Windows.Forms.Button();
            this.SS = new System.Windows.Forms.PictureBox();
            this.pnlacc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsave.Location = new System.Drawing.Point(494, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(90, 33);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsave_KeyDown);
            // 
            // btnclear
            // 
            this.btnclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclear.Location = new System.Drawing.Point(650, 9);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(89, 33);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            this.btnclear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnclear_KeyDown);
            // 
            // lblplus
            // 
            this.lblplus.AutoSize = true;
            this.lblplus.BackColor = System.Drawing.Color.Lime;
            this.lblplus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblplus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplus.Location = new System.Drawing.Point(-2, 9);
            this.lblplus.Name = "lblplus";
            this.lblplus.Size = new System.Drawing.Size(32, 33);
            this.lblplus.TabIndex = 3;
            this.lblplus.Text = "+";
            this.lblplus.Click += new System.EventHandler(this.lblplus_Click);
            this.lblplus.MouseLeave += new System.EventHandler(this.lblplus_MouseLeave);
            this.lblplus.MouseHover += new System.EventHandler(this.lblplus_MouseHover);
            // 
            // pnlacc
            // 
            this.pnlacc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlacc.Controls.Add(this.button1);
            this.pnlacc.Controls.Add(this.btneraser);
            this.pnlacc.Location = new System.Drawing.Point(-2, 9);
            this.pnlacc.Name = "pnlacc";
            this.pnlacc.Size = new System.Drawing.Size(76, 138);
            this.pnlacc.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(14, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Draw";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btneraser
            // 
            this.btneraser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneraser.Image = global::Creative_Ideas.Properties.Resources.btnEraser_normal;
            this.btneraser.Location = new System.Drawing.Point(14, 21);
            this.btneraser.Name = "btneraser";
            this.btneraser.Size = new System.Drawing.Size(35, 33);
            this.btneraser.TabIndex = 0;
            this.btneraser.UseVisualStyleBackColor = true;
            this.btneraser.Click += new System.EventHandler(this.btneraser_Click);
            this.btneraser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btneraser_KeyDown);
            this.btneraser.MouseLeave += new System.EventHandler(this.btneraser_MouseLeave);
            this.btneraser.MouseHover += new System.EventHandler(this.btneraser_MouseHover);
            // 
            // btnGTF
            // 
            this.btnGTF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGTF.Location = new System.Drawing.Point(805, 9);
            this.btnGTF.Name = "btnGTF";
            this.btnGTF.Size = new System.Drawing.Size(90, 33);
            this.btnGTF.TabIndex = 5;
            this.btnGTF.Text = "Go to full";
            this.btnGTF.UseVisualStyleBackColor = true;
            this.btnGTF.Click += new System.EventHandler(this.btnGTF_Click);
            this.btnGTF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnGTF_KeyDown);
            // 
            // SS
            // 
            this.SS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SS.BackColor = System.Drawing.Color.White;
            this.SS.Location = new System.Drawing.Point(53, 58);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(810, 439);
            this.SS.TabIndex = 0;
            this.SS.TabStop = false;
            this.SS.Click += new System.EventHandler(this.SS_Click);
            this.SS.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SS_MouseClick);
            this.SS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SS_MouseDown);
            this.SS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SS_MouseMove_1);
            this.SS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SS_MouseUp);
            // 
            // Sketch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(923, 535);
            this.Controls.Add(this.btnGTF);
            this.Controls.Add(this.pnlacc);
            this.Controls.Add(this.lblplus);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.SS);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sketch";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Sketch_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sketch_KeyDown);
            this.pnlacc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SS;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lblplus;
        private System.Windows.Forms.Panel pnlacc;
        private System.Windows.Forms.Button btneraser;
        private System.Windows.Forms.Button btnGTF;
        private System.Windows.Forms.Button button1;
    }
}