namespace Creative_Ideas
{
    partial class Character
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label charIDLabel;
            System.Windows.Forms.Label charnameLabel;
            System.Windows.Forms.Label descriptive_TraitsLabel;
            System.Windows.Forms.Label personality_TraitsLabel;
            System.Windows.Forms.Label occupationLabel;
            System.Windows.Forms.Label inner_DriveLabel;
            System.Windows.Forms.Label themeIDLabel;
            System.Windows.Forms.Label imgLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Character));
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.creativeIdeasDataSet2 = new Creative_Ideas.CreativeIdeasDataSet2();
            this.charactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.charactTableAdapter = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.CharactTableAdapter();
            this.tableAdapterManager = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager();
            this.charactBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.charactBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.charIDTextBox = new System.Windows.Forms.TextBox();
            this.charnameTextBox = new System.Windows.Forms.TextBox();
            this.descriptive_TraitsTextBox = new System.Windows.Forms.TextBox();
            this.personality_TraitsTextBox = new System.Windows.Forms.TextBox();
            this.occupationTextBox = new System.Windows.Forms.TextBox();
            this.inner_DriveTextBox = new System.Windows.Forms.TextBox();
            this.themeIDTextBox = new System.Windows.Forms.TextBox();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.charactDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnap = new System.Windows.Forms.Button();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themeTableAdapter = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.ThemeTableAdapter();
            this.themeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            charIDLabel = new System.Windows.Forms.Label();
            charnameLabel = new System.Windows.Forms.Label();
            descriptive_TraitsLabel = new System.Windows.Forms.Label();
            personality_TraitsLabel = new System.Windows.Forms.Label();
            occupationLabel = new System.Windows.Forms.Label();
            inner_DriveLabel = new System.Windows.Forms.Label();
            themeIDLabel = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactBindingNavigator)).BeginInit();
            this.charactBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // charIDLabel
            // 
            charIDLabel.AutoSize = true;
            charIDLabel.Location = new System.Drawing.Point(74, 76);
            charIDLabel.Name = "charIDLabel";
            charIDLabel.Size = new System.Drawing.Size(46, 13);
            charIDLabel.TabIndex = 15;
            charIDLabel.Text = "Char ID:";
            // 
            // charnameLabel
            // 
            charnameLabel.AutoSize = true;
            charnameLabel.Location = new System.Drawing.Point(74, 102);
            charnameLabel.Name = "charnameLabel";
            charnameLabel.Size = new System.Drawing.Size(58, 13);
            charnameLabel.TabIndex = 17;
            charnameLabel.Text = "Charname:";
            // 
            // descriptive_TraitsLabel
            // 
            descriptive_TraitsLabel.AutoSize = true;
            descriptive_TraitsLabel.Location = new System.Drawing.Point(74, 128);
            descriptive_TraitsLabel.Name = "descriptive_TraitsLabel";
            descriptive_TraitsLabel.Size = new System.Drawing.Size(92, 13);
            descriptive_TraitsLabel.TabIndex = 19;
            descriptive_TraitsLabel.Text = "Descriptive Traits:";
            // 
            // personality_TraitsLabel
            // 
            personality_TraitsLabel.AutoSize = true;
            personality_TraitsLabel.Location = new System.Drawing.Point(74, 154);
            personality_TraitsLabel.Name = "personality_TraitsLabel";
            personality_TraitsLabel.Size = new System.Drawing.Size(90, 13);
            personality_TraitsLabel.TabIndex = 21;
            personality_TraitsLabel.Text = "Personality Traits:";
            // 
            // occupationLabel
            // 
            occupationLabel.AutoSize = true;
            occupationLabel.Location = new System.Drawing.Point(74, 180);
            occupationLabel.Name = "occupationLabel";
            occupationLabel.Size = new System.Drawing.Size(65, 13);
            occupationLabel.TabIndex = 23;
            occupationLabel.Text = "Occupation:";
            // 
            // inner_DriveLabel
            // 
            inner_DriveLabel.AutoSize = true;
            inner_DriveLabel.Location = new System.Drawing.Point(74, 206);
            inner_DriveLabel.Name = "inner_DriveLabel";
            inner_DriveLabel.Size = new System.Drawing.Size(62, 13);
            inner_DriveLabel.TabIndex = 25;
            inner_DriveLabel.Text = "Inner Drive:";
            // 
            // themeIDLabel
            // 
            themeIDLabel.AutoSize = true;
            themeIDLabel.Location = new System.Drawing.Point(74, 232);
            themeIDLabel.Name = "themeIDLabel";
            themeIDLabel.Size = new System.Drawing.Size(57, 13);
            themeIDLabel.TabIndex = 27;
            themeIDLabel.Text = "Theme ID:";
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Location = new System.Drawing.Point(93, 344);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(27, 13);
            imgLabel.TabIndex = 29;
            imgLabel.Text = "Img:";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(32, 464);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(66, 23);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Add New";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(134, 464);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 23);
            this.btndelete.TabIndex = 13;
            this.btndelete.Text = "Save";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(232, 464);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(66, 23);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Delete";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // creativeIdeasDataSet2
            // 
            this.creativeIdeasDataSet2.DataSetName = "CreativeIdeasDataSet2";
            this.creativeIdeasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // charactBindingSource
            // 
            this.charactBindingSource.DataMember = "Charact";
            this.charactBindingSource.DataSource = this.creativeIdeasDataSet2;
            // 
            // charactTableAdapter
            // 
            this.charactTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.ActTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharactTableAdapter = this.charactTableAdapter;
            this.tableAdapterManager.MotiveTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.ScriptTableAdapter = null;
            this.tableAdapterManager.ThemeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // charactBindingNavigator
            // 
            this.charactBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.charactBindingNavigator.BindingSource = this.charactBindingSource;
            this.charactBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.charactBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.charactBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.charactBindingNavigatorSaveItem});
            this.charactBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.charactBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.charactBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.charactBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.charactBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.charactBindingNavigator.Name = "charactBindingNavigator";
            this.charactBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.charactBindingNavigator.Size = new System.Drawing.Size(1256, 25);
            this.charactBindingNavigator.TabIndex = 15;
            this.charactBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // charactBindingNavigatorSaveItem
            // 
            this.charactBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.charactBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("charactBindingNavigatorSaveItem.Image")));
            this.charactBindingNavigatorSaveItem.Name = "charactBindingNavigatorSaveItem";
            this.charactBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.charactBindingNavigatorSaveItem.Text = "Save Data";
            this.charactBindingNavigatorSaveItem.Click += new System.EventHandler(this.charactBindingNavigatorSaveItem_Click);
            // 
            // charIDTextBox
            // 
            this.charIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.charactBindingSource, "CharID", true));
            this.charIDTextBox.Location = new System.Drawing.Point(172, 73);
            this.charIDTextBox.Name = "charIDTextBox";
            this.charIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.charIDTextBox.TabIndex = 16;
            // 
            // charnameTextBox
            // 
            this.charnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.charactBindingSource, "Charname", true));
            this.charnameTextBox.Location = new System.Drawing.Point(172, 99);
            this.charnameTextBox.Name = "charnameTextBox";
            this.charnameTextBox.Size = new System.Drawing.Size(174, 20);
            this.charnameTextBox.TabIndex = 18;
            // 
            // descriptive_TraitsTextBox
            // 
            this.descriptive_TraitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.charactBindingSource, "Descriptive_Traits", true));
            this.descriptive_TraitsTextBox.Location = new System.Drawing.Point(172, 125);
            this.descriptive_TraitsTextBox.Name = "descriptive_TraitsTextBox";
            this.descriptive_TraitsTextBox.Size = new System.Drawing.Size(174, 20);
            this.descriptive_TraitsTextBox.TabIndex = 20;
            // 
            // personality_TraitsTextBox
            // 
            this.personality_TraitsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.charactBindingSource, "Personality_Traits", true));
            this.personality_TraitsTextBox.Location = new System.Drawing.Point(172, 151);
            this.personality_TraitsTextBox.Name = "personality_TraitsTextBox";
            this.personality_TraitsTextBox.Size = new System.Drawing.Size(174, 20);
            this.personality_TraitsTextBox.TabIndex = 22;
            // 
            // occupationTextBox
            // 
            this.occupationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.charactBindingSource, "Occupation", true));
            this.occupationTextBox.Location = new System.Drawing.Point(172, 177);
            this.occupationTextBox.Name = "occupationTextBox";
            this.occupationTextBox.Size = new System.Drawing.Size(174, 20);
            this.occupationTextBox.TabIndex = 24;
            // 
            // inner_DriveTextBox
            // 
            this.inner_DriveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.charactBindingSource, "Inner_Drive", true));
            this.inner_DriveTextBox.Location = new System.Drawing.Point(172, 203);
            this.inner_DriveTextBox.Name = "inner_DriveTextBox";
            this.inner_DriveTextBox.Size = new System.Drawing.Size(174, 20);
            this.inner_DriveTextBox.TabIndex = 26;
            // 
            // themeIDTextBox
            // 
            this.themeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.charactBindingSource, "ThemeID", true));
            this.themeIDTextBox.Location = new System.Drawing.Point(172, 229);
            this.themeIDTextBox.Name = "themeIDTextBox";
            this.themeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.themeIDTextBox.TabIndex = 28;
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.charactBindingSource, "Img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(172, 275);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(148, 143);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 30;
            this.imgPictureBox.TabStop = false;
            // 
            // charactDataGridView
            // 
            this.charactDataGridView.AutoGenerateColumns = false;
            this.charactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.charactDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewImageColumn1});
            this.charactDataGridView.DataSource = this.charactBindingSource;
            this.charactDataGridView.Location = new System.Drawing.Point(375, 25);
            this.charactDataGridView.Name = "charactDataGridView";
            this.charactDataGridView.Size = new System.Drawing.Size(840, 220);
            this.charactDataGridView.TabIndex = 30;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CharID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CharID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Charname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Charname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descriptive_Traits";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descriptive_Traits";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Personality_Traits";
            this.dataGridViewTextBoxColumn4.HeaderText = "Personality_Traits";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Occupation";
            this.dataGridViewTextBoxColumn5.HeaderText = "Occupation";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Inner_Drive";
            this.dataGridViewTextBoxColumn6.HeaderText = "Inner_Drive";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ThemeID";
            this.dataGridViewTextBoxColumn7.HeaderText = "ThemeID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Img";
            this.dataGridViewImageColumn1.HeaderText = "Img";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnap
            // 
            this.btnap.Location = new System.Drawing.Point(326, 334);
            this.btnap.Name = "btnap";
            this.btnap.Size = new System.Drawing.Size(107, 23);
            this.btnap.TabIndex = 52;
            this.btnap.Text = "Add/ Change Pic";
            this.btnap.UseVisualStyleBackColor = true;
            this.btnap.Click += new System.EventHandler(this.btnap_Click);
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataMember = "Theme";
            this.themeBindingSource.DataSource = this.creativeIdeasDataSet2;
            // 
            // themeTableAdapter
            // 
            this.themeTableAdapter.ClearBeforeFill = true;
            // 
            // themeDataGridView
            // 
            this.themeDataGridView.AutoGenerateColumns = false;
            this.themeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.themeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.themeDataGridView.DataSource = this.themeBindingSource;
            this.themeDataGridView.Location = new System.Drawing.Point(926, 296);
            this.themeDataGridView.Name = "themeDataGridView";
            this.themeDataGridView.Size = new System.Drawing.Size(300, 220);
            this.themeDataGridView.TabIndex = 52;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ThemeID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ThemeID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ThemeName";
            this.dataGridViewTextBoxColumn9.HeaderText = "ThemeName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nature";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nature";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Vibe";
            this.dataGridViewTextBoxColumn11.HeaderText = "Vibe";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn12.HeaderText = "Location";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Emotional_State";
            this.dataGridViewTextBoxColumn13.HeaderText = "Emotional_State";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Scientific_Evidence";
            this.dataGridViewTextBoxColumn14.HeaderText = "Scientific_Evidence";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Creative_Ideas.Properties.Resources.Help;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(375, 251);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 53;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(478, 328);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(73, 35);
            this.btnclear.TabIndex = 54;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Character
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Creative_Ideas.Properties.Resources.Character;
            this.ClientSize = new System.Drawing.Size(1256, 528);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.themeDataGridView);
            this.Controls.Add(this.btnap);
            this.Controls.Add(this.charactDataGridView);
            this.Controls.Add(charIDLabel);
            this.Controls.Add(this.charIDTextBox);
            this.Controls.Add(charnameLabel);
            this.Controls.Add(this.charnameTextBox);
            this.Controls.Add(descriptive_TraitsLabel);
            this.Controls.Add(this.descriptive_TraitsTextBox);
            this.Controls.Add(personality_TraitsLabel);
            this.Controls.Add(this.personality_TraitsTextBox);
            this.Controls.Add(occupationLabel);
            this.Controls.Add(this.occupationTextBox);
            this.Controls.Add(inner_DriveLabel);
            this.Controls.Add(this.inner_DriveTextBox);
            this.Controls.Add(themeIDLabel);
            this.Controls.Add(this.themeIDTextBox);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.charactBindingNavigator);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Character";
            this.Text = "Character";
            this.Load += new System.EventHandler(this.Character_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactBindingNavigator)).EndInit();
            this.charactBindingNavigator.ResumeLayout(false);
            this.charactBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charactDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btncancel;
        private CreativeIdeasDataSet2 creativeIdeasDataSet2;
        private System.Windows.Forms.BindingSource charactBindingSource;
        private CreativeIdeasDataSet2TableAdapters.CharactTableAdapter charactTableAdapter;
        private CreativeIdeasDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator charactBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton charactBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox charIDTextBox;
        private System.Windows.Forms.TextBox charnameTextBox;
        private System.Windows.Forms.TextBox descriptive_TraitsTextBox;
        private System.Windows.Forms.TextBox personality_TraitsTextBox;
        private System.Windows.Forms.TextBox occupationTextBox;
        private System.Windows.Forms.TextBox inner_DriveTextBox;
        private System.Windows.Forms.TextBox themeIDTextBox;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.DataGridView charactDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button btnap;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private CreativeIdeasDataSet2TableAdapters.ThemeTableAdapter themeTableAdapter;
        private System.Windows.Forms.DataGridView themeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnclear;

    }
}