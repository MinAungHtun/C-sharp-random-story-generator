namespace Creative_Ideas
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.LoadingVP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingVP)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingVP
            // 
            this.LoadingVP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingVP.Enabled = true;
            this.LoadingVP.Location = new System.Drawing.Point(0, 0);
            this.LoadingVP.Name = "LoadingVP";
            this.LoadingVP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("LoadingVP.OcxState")));
            this.LoadingVP.Size = new System.Drawing.Size(284, 263);
            this.LoadingVP.TabIndex = 1;
            this.LoadingVP.Enter += new System.EventHandler(this.LoadingVP_Enter);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.LoadingVP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loading";
            this.Text = "Creative Ideas";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Loading_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingVP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer LoadingVP;
    }
}