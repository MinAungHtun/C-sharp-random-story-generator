namespace Creative_Ideas
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.VideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.cbx1 = new System.Windows.Forms.ComboBox();
            this.cbx3 = new System.Windows.Forms.ComboBox();
            this.cbx4 = new System.Windows.Forms.ComboBox();
            this.cbx5 = new System.Windows.Forms.ComboBox();
            this.btnanimate = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblF = new System.Windows.Forms.Label();
            this.lblu = new System.Windows.Forms.Label();
            this.lblL = new System.Windows.Forms.Label();
            this.lblLL = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.lblo = new System.Windows.Forms.Label();
            this.lblr = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.btnaddpic = new System.Windows.Forms.Button();
            this.btntweak = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            this.SuspendLayout();
            // 
            // VideoPlayer
            // 
            this.VideoPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoPlayer.Enabled = true;
            this.VideoPlayer.Location = new System.Drawing.Point(0, 0);
            this.VideoPlayer.Name = "VideoPlayer";
            this.VideoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoPlayer.OcxState")));
            this.VideoPlayer.Size = new System.Drawing.Size(1130, 637);
            this.VideoPlayer.TabIndex = 18;
            this.VideoPlayer.TabStop = false;
            this.VideoPlayer.KeyDownEvent += new AxWMPLib._WMPOCXEvents_KeyDownEventHandler(this.VideoPlayer_KeyDownEvent);
            this.VideoPlayer.Enter += new System.EventHandler(this.VideoPlayer_Enter);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Charlemagne Std", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(110, 14);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Cryuff";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxsetting_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 72);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Location = new System.Drawing.Point(212, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Help/Support";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Creative_Ideas.Properties.Resources.Kobe;
            this.pictureBox2.Location = new System.Drawing.Point(16, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Creative_Ideas.Properties.Resources.setting;
            this.pictureBox1.Location = new System.Drawing.Point(171, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 33);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl1.Location = new System.Drawing.Point(843, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(245, 33);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Don\'t have any ideas?";
            // 
            // tbx5
            // 
            this.tbx5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx5.Location = new System.Drawing.Point(236, 413);
            this.tbx5.MaximumSize = new System.Drawing.Size(1000, 300);
            this.tbx5.MaxLength = 99999999;
            this.tbx5.Multiline = true;
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(709, 142);
            this.tbx5.TabIndex = 17;
            this.tbx5.Text = resources.GetString("tbx5.Text");
            this.tbx5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbx5_KeyDown);
            // 
            // cbx1
            // 
            this.cbx1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx1.FormattingEnabled = true;
            this.cbx1.Location = new System.Drawing.Point(105, 218);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(138, 21);
            this.cbx1.TabIndex = 7;
            this.cbx1.SelectedIndexChanged += new System.EventHandler(this.cbx1_SelectedIndexChanged);
            this.cbx1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx1_KeyDown);
            this.cbx1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx1_MouseClick);
            // 
            // cbx3
            // 
            this.cbx3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx3.FormattingEnabled = true;
            this.cbx3.Location = new System.Drawing.Point(806, 218);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(188, 21);
            this.cbx3.TabIndex = 10;
            this.cbx3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx3_KeyDown);
            this.cbx3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx3_MouseClick);
            // 
            // cbx4
            // 
            this.cbx4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx4.FormattingEnabled = true;
            this.cbx4.Location = new System.Drawing.Point(553, 218);
            this.cbx4.Name = "cbx4";
            this.cbx4.Size = new System.Drawing.Size(232, 21);
            this.cbx4.TabIndex = 9;
            this.cbx4.SelectedIndexChanged += new System.EventHandler(this.cbx4_SelectedIndexChanged);
            this.cbx4.SelectedValueChanged += new System.EventHandler(this.cbx4_SelectedValueChanged);
            this.cbx4.TextChanged += new System.EventHandler(this.cbx4_TextChanged);
            this.cbx4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx4_KeyDown);
            this.cbx4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx4_MouseClick);
            // 
            // cbx5
            // 
            this.cbx5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx5.FormattingEnabled = true;
            this.cbx5.Location = new System.Drawing.Point(282, 218);
            this.cbx5.Name = "cbx5";
            this.cbx5.Size = new System.Drawing.Size(236, 21);
            this.cbx5.TabIndex = 8;
            this.cbx5.SelectedIndexChanged += new System.EventHandler(this.cbx5_SelectedIndexChanged);
            this.cbx5.SelectedValueChanged += new System.EventHandler(this.cbx5_SelectedValueChanged);
            this.cbx5.TextChanged += new System.EventHandler(this.cbx5_TextChanged);
            this.cbx5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx5_KeyDown);
            this.cbx5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx5_MouseClick);
            // 
            // btnanimate
            // 
            this.btnanimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnanimate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnanimate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnanimate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnanimate.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanimate.ForeColor = System.Drawing.Color.LawnGreen;
            this.btnanimate.Location = new System.Drawing.Point(915, 579);
            this.btnanimate.MaximumSize = new System.Drawing.Size(300, 50);
            this.btnanimate.Name = "btnanimate";
            this.btnanimate.Size = new System.Drawing.Size(135, 37);
            this.btnanimate.TabIndex = 16;
            this.btnanimate.Text = "Animate";
            this.btnanimate.UseVisualStyleBackColor = false;
            this.btnanimate.Click += new System.EventHandler(this.btnanimate_Click);
            this.btnanimate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnanimate_KeyDown);
            this.btnanimate.MouseLeave += new System.EventHandler(this.btnanimate_MouseLeave);
            this.btnanimate.MouseHover += new System.EventHandler(this.btnanimate_MouseHover);
            // 
            // btncancel
            // 
            this.btncancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncancel.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Red;
            this.btncancel.Location = new System.Drawing.Point(481, 579);
            this.btncancel.MaximumSize = new System.Drawing.Size(300, 50);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(135, 37);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            this.btncancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btncancel_KeyDown);
            this.btncancel.MouseLeave += new System.EventHandler(this.btncancel_MouseLeave);
            this.btncancel.MouseHover += new System.EventHandler(this.btncancel_MouseHover);
            // 
            // btnsave
            // 
            this.btnsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnsave.Location = new System.Drawing.Point(110, 579);
            this.btnsave.MaximumSize = new System.Drawing.Size(300, 50);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(135, 37);
            this.btnsave.TabIndex = 14;
            this.btnsave.Text = "Save Story";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            this.btnsave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsave_KeyDown);
            this.btnsave.MouseLeave += new System.EventHandler(this.btnsave_MouseLeave);
            this.btnsave.MouseHover += new System.EventHandler(this.btnsave_MouseHover);
            // 
            // btnPaint
            // 
            this.btnPaint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPaint.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaint.ForeColor = System.Drawing.Color.Orchid;
            this.btnPaint.Location = new System.Drawing.Point(428, 12);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(301, 103);
            this.btnPaint.TabIndex = 2;
            this.btnPaint.Text = "            Just give me                       a draft or something!     ";
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            this.btnPaint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btncombine_KeyDown);
            this.btnPaint.MouseLeave += new System.EventHandler(this.btnPaint_MouseLeave);
            this.btnPaint.MouseHover += new System.EventHandler(this.btnPaint_MouseHover);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Olive;
            this.button2.Location = new System.Drawing.Point(901, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Give me one!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button2_KeyDown);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.Location = new System.Drawing.Point(976, 441);
            this.btnClearAll.MaximumSize = new System.Drawing.Size(300, 50);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(135, 50);
            this.btnClearAll.TabIndex = 13;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            this.btnClearAll.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnClearAll_KeyDown);
            this.btnClearAll.MouseLeave += new System.EventHandler(this.btnClearAll_MouseLeave);
            this.btnClearAll.MouseHover += new System.EventHandler(this.btnClearAll_MouseHover);
            // 
            // lblF
            // 
            this.lblF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblF.AutoSize = true;
            this.lblF.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblF.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.ForeColor = System.Drawing.Color.Beige;
            this.lblF.Location = new System.Drawing.Point(79, 403);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(18, 18);
            this.lblF.TabIndex = 22;
            this.lblF.Text = "F";
            // 
            // lblu
            // 
            this.lblu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblu.AutoSize = true;
            this.lblu.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblu.ForeColor = System.Drawing.Color.Red;
            this.lblu.Location = new System.Drawing.Point(98, 403);
            this.lblu.Name = "lblu";
            this.lblu.Size = new System.Drawing.Size(17, 18);
            this.lblu.TabIndex = 26;
            this.lblu.Text = "u";
            // 
            // lblL
            // 
            this.lblL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblL.AutoSize = true;
            this.lblL.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblL.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblL.ForeColor = System.Drawing.Color.Lime;
            this.lblL.Location = new System.Drawing.Point(117, 403);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(13, 18);
            this.lblL.TabIndex = 23;
            this.lblL.Text = "l";
            // 
            // lblLL
            // 
            this.lblLL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLL.AutoSize = true;
            this.lblLL.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblLL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLL.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLL.ForeColor = System.Drawing.Color.Lime;
            this.lblLL.Location = new System.Drawing.Point(132, 403);
            this.lblLL.Name = "lblLL";
            this.lblLL.Size = new System.Drawing.Size(13, 18);
            this.lblLL.TabIndex = 24;
            this.lblLL.Text = "l";
            // 
            // lblS
            // 
            this.lblS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblS.AutoSize = true;
            this.lblS.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblS.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.ForeColor = System.Drawing.Color.Olive;
            this.lblS.Location = new System.Drawing.Point(70, 432);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(16, 18);
            this.lblS.TabIndex = 25;
            this.lblS.Text = "S";
            // 
            // lblt
            // 
            this.lblt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblt.AutoSize = true;
            this.lblt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblt.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblt.Location = new System.Drawing.Point(90, 432);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(14, 18);
            this.lblt.TabIndex = 30;
            this.lblt.Text = "t";
            // 
            // lblo
            // 
            this.lblo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblo.AutoSize = true;
            this.lblo.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblo.Location = new System.Drawing.Point(107, 432);
            this.lblo.Name = "lblo";
            this.lblo.Size = new System.Drawing.Size(15, 18);
            this.lblo.TabIndex = 27;
            this.lblo.Text = "o";
            // 
            // lblr
            // 
            this.lblr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblr.AutoSize = true;
            this.lblr.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lblr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblr.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblr.Location = new System.Drawing.Point(126, 432);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(14, 18);
            this.lblr.TabIndex = 28;
            this.lblr.Text = "r";
            // 
            // lbly
            // 
            this.lbly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbly.AutoSize = true;
            this.lbly.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbly.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbly.Location = new System.Drawing.Point(142, 432);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(21, 18);
            this.lbly.TabIndex = 29;
            this.lbly.Text = "y:";
            // 
            // btnaddpic
            // 
            this.btnaddpic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnaddpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnaddpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddpic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnaddpic.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddpic.ForeColor = System.Drawing.Color.SlateGray;
            this.btnaddpic.Location = new System.Drawing.Point(102, 308);
            this.btnaddpic.MaximumSize = new System.Drawing.Size(300, 50);
            this.btnaddpic.Name = "btnaddpic";
            this.btnaddpic.Size = new System.Drawing.Size(141, 50);
            this.btnaddpic.TabIndex = 11;
            this.btnaddpic.Text = "Validate and Edit Story";
            this.btnaddpic.UseVisualStyleBackColor = false;
            this.btnaddpic.Click += new System.EventHandler(this.btnaddpic_Click);
            this.btnaddpic.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnaddpic_KeyDown);
            this.btnaddpic.MouseLeave += new System.EventHandler(this.btnaddpic_MouseLeave);
            this.btnaddpic.MouseHover += new System.EventHandler(this.btnaddpic_MouseHover);
            // 
            // btntweak
            // 
            this.btntweak.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btntweak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btntweak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btntweak.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntweak.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntweak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btntweak.Location = new System.Drawing.Point(806, 308);
            this.btntweak.MaximumSize = new System.Drawing.Size(300, 50);
            this.btntweak.Name = "btntweak";
            this.btntweak.Size = new System.Drawing.Size(141, 50);
            this.btntweak.TabIndex = 12;
            this.btntweak.Text = "Exit";
            this.btntweak.UseVisualStyleBackColor = false;
            this.btntweak.Click += new System.EventHandler(this.btntweak_Click);
            this.btntweak.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btntweak_KeyDown);
            this.btntweak.MouseLeave += new System.EventHandler(this.btntweak_MouseLeave);
            this.btntweak.MouseHover += new System.EventHandler(this.btntweak_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(953, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 47;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Image = global::Creative_Ideas.Properties.Resources.Edit;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(972, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 46;
            this.button1.Text = "An Action";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button1_KeyDown);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pbx4
            // 
            this.pbx4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbx4.BackColor = System.Drawing.Color.White;
            this.pbx4.Location = new System.Drawing.Point(553, 271);
            this.pbx4.MaximumSize = new System.Drawing.Size(300, 300);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(232, 113);
            this.pbx4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx4.TabIndex = 45;
            this.pbx4.TabStop = false;
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn4.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Tomato;
            this.btn4.Image = global::Creative_Ideas.Properties.Resources.Edit;
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn4.Location = new System.Drawing.Point(341, 167);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(130, 23);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Character";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn4_KeyDown_1);
            this.btn4.MouseLeave += new System.EventHandler(this.btn4_MouseLeave);
            this.btn4.MouseHover += new System.EventHandler(this.btn4_MouseHover);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn3.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Crimson;
            this.btn3.Image = global::Creative_Ideas.Properties.Resources.Edit;
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn3.Location = new System.Drawing.Point(602, 167);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(127, 23);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Setting";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn3_KeyDown);
            this.btn3.MouseLeave += new System.EventHandler(this.btn3_MouseLeave);
            this.btn3.MouseHover += new System.EventHandler(this.btn3_MouseHover);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn2.Image = global::Creative_Ideas.Properties.Resources.Edit;
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn2.Location = new System.Drawing.Point(837, 167);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(139, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "Motive";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn2_KeyDown);
            this.btn2.MouseLeave += new System.EventHandler(this.btn2_MouseLeave);
            this.btn2.MouseHover += new System.EventHandler(this.btn2_MouseHover);
            // 
            // pbx3
            // 
            this.pbx3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbx3.BackColor = System.Drawing.Color.White;
            this.pbx3.Location = new System.Drawing.Point(282, 271);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(236, 113);
            this.pbx3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx3.TabIndex = 35;
            this.pbx3.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.SlateBlue;
            this.btn1.Image = global::Creative_Ideas.Properties.Resources.Edit;
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn1.Location = new System.Drawing.Point(116, 167);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 23);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Theme";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn1_KeyDown);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            this.btn1.MouseHover += new System.EventHandler(this.btn1_MouseHover);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 637);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnaddpic);
            this.Controls.Add(this.btntweak);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.lblo);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblLL);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lblu);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnPaint);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnanimate);
            this.Controls.Add(this.cbx5);
            this.Controls.Add(this.cbx4);
            this.Controls.Add(this.cbx3);
            this.Controls.Add(this.cbx1);
            this.Controls.Add(this.tbx5);
            this.Controls.Add(this.pbx4);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.pbx3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VideoPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Main_Load);
            this.DoubleClick += new System.EventHandler(this.Main_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.VideoPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer VideoPlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.TextBox tbx5;
        private System.Windows.Forms.ComboBox cbx1;
        private System.Windows.Forms.ComboBox cbx3;
        private System.Windows.Forms.ComboBox cbx4;
        private System.Windows.Forms.ComboBox cbx5;
        private System.Windows.Forms.Button btnanimate;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.Label lblu;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblLL;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblt;
        private System.Windows.Forms.Label lblo;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Button btnaddpic;
        private System.Windows.Forms.Button btntweak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.TextBox textBox1;
    }
}