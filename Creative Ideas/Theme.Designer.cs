namespace Creative_Ideas
{
    partial class Theme
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
            System.Windows.Forms.Label themeIDLabel;
            System.Windows.Forms.Label themeNameLabel;
            System.Windows.Forms.Label natureLabel;
            System.Windows.Forms.Label vibeLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label emotional_StateLabel;
            System.Windows.Forms.Label scientific_EvidenceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Theme));
            this.creativeIdeasDataSet2 = new Creative_Ideas.CreativeIdeasDataSet2();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themeTableAdapter = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.ThemeTableAdapter();
            this.tableAdapterManager = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager();
            this.themeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.themeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.themeIDTextBox = new System.Windows.Forms.TextBox();
            this.themeNameTextBox = new System.Windows.Forms.TextBox();
            this.natureTextBox = new System.Windows.Forms.TextBox();
            this.vibeTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.emotional_StateTextBox = new System.Windows.Forms.TextBox();
            this.scientific_EvidenceTextBox = new System.Windows.Forms.TextBox();
            this.themeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancel = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsavenow = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            themeIDLabel = new System.Windows.Forms.Label();
            themeNameLabel = new System.Windows.Forms.Label();
            natureLabel = new System.Windows.Forms.Label();
            vibeLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            emotional_StateLabel = new System.Windows.Forms.Label();
            scientific_EvidenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingNavigator)).BeginInit();
            this.themeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // themeIDLabel
            // 
            themeIDLabel.AutoSize = true;
            themeIDLabel.Location = new System.Drawing.Point(77, 97);
            themeIDLabel.Name = "themeIDLabel";
            themeIDLabel.Size = new System.Drawing.Size(57, 13);
            themeIDLabel.TabIndex = 1;
            themeIDLabel.Text = "Theme ID:";
            // 
            // themeNameLabel
            // 
            themeNameLabel.AutoSize = true;
            themeNameLabel.Location = new System.Drawing.Point(77, 123);
            themeNameLabel.Name = "themeNameLabel";
            themeNameLabel.Size = new System.Drawing.Size(74, 13);
            themeNameLabel.TabIndex = 3;
            themeNameLabel.Text = "Theme Name:";
            // 
            // natureLabel
            // 
            natureLabel.AutoSize = true;
            natureLabel.Location = new System.Drawing.Point(77, 149);
            natureLabel.Name = "natureLabel";
            natureLabel.Size = new System.Drawing.Size(42, 13);
            natureLabel.TabIndex = 5;
            natureLabel.Text = "Nature:";
            // 
            // vibeLabel
            // 
            vibeLabel.AutoSize = true;
            vibeLabel.Location = new System.Drawing.Point(77, 175);
            vibeLabel.Name = "vibeLabel";
            vibeLabel.Size = new System.Drawing.Size(31, 13);
            vibeLabel.TabIndex = 7;
            vibeLabel.Text = "Vibe:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(77, 201);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 9;
            locationLabel.Text = "Location:";
            // 
            // emotional_StateLabel
            // 
            emotional_StateLabel.AutoSize = true;
            emotional_StateLabel.Location = new System.Drawing.Point(77, 227);
            emotional_StateLabel.Name = "emotional_StateLabel";
            emotional_StateLabel.Size = new System.Drawing.Size(84, 13);
            emotional_StateLabel.TabIndex = 11;
            emotional_StateLabel.Text = "Emotional State:";
            // 
            // scientific_EvidenceLabel
            // 
            scientific_EvidenceLabel.AutoSize = true;
            scientific_EvidenceLabel.Location = new System.Drawing.Point(77, 253);
            scientific_EvidenceLabel.Name = "scientific_EvidenceLabel";
            scientific_EvidenceLabel.Size = new System.Drawing.Size(101, 13);
            scientific_EvidenceLabel.TabIndex = 13;
            scientific_EvidenceLabel.Text = "Scientific Evidence:";
            // 
            // creativeIdeasDataSet2
            // 
            this.creativeIdeasDataSet2.DataSetName = "CreativeIdeasDataSet2";
            this.creativeIdeasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.ActTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharactTableAdapter = null;
            this.tableAdapterManager.MotiveTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.ScriptTableAdapter = null;
            this.tableAdapterManager.ThemeTableAdapter = this.themeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // themeBindingNavigator
            // 
            this.themeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.themeBindingNavigator.BindingSource = this.themeBindingSource;
            this.themeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.themeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.themeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.themeBindingNavigatorSaveItem});
            this.themeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.themeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.themeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.themeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.themeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.themeBindingNavigator.Name = "themeBindingNavigator";
            this.themeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.themeBindingNavigator.Size = new System.Drawing.Size(1266, 25);
            this.themeBindingNavigator.TabIndex = 0;
            this.themeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // themeBindingNavigatorSaveItem
            // 
            this.themeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.themeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("themeBindingNavigatorSaveItem.Image")));
            this.themeBindingNavigatorSaveItem.Name = "themeBindingNavigatorSaveItem";
            this.themeBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.themeBindingNavigatorSaveItem.Text = "Save Data";
            this.themeBindingNavigatorSaveItem.Click += new System.EventHandler(this.themeBindingNavigatorSaveItem_Click);
            // 
            // themeIDTextBox
            // 
            this.themeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.themeBindingSource, "ThemeID", true));
            this.themeIDTextBox.Location = new System.Drawing.Point(184, 94);
            this.themeIDTextBox.Name = "themeIDTextBox";
            this.themeIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.themeIDTextBox.TabIndex = 2;
            // 
            // themeNameTextBox
            // 
            this.themeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.themeBindingSource, "ThemeName", true));
            this.themeNameTextBox.Location = new System.Drawing.Point(184, 120);
            this.themeNameTextBox.Name = "themeNameTextBox";
            this.themeNameTextBox.Size = new System.Drawing.Size(209, 20);
            this.themeNameTextBox.TabIndex = 4;
            // 
            // natureTextBox
            // 
            this.natureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.themeBindingSource, "Nature", true));
            this.natureTextBox.Location = new System.Drawing.Point(184, 146);
            this.natureTextBox.Name = "natureTextBox";
            this.natureTextBox.Size = new System.Drawing.Size(209, 20);
            this.natureTextBox.TabIndex = 6;
            // 
            // vibeTextBox
            // 
            this.vibeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.themeBindingSource, "Vibe", true));
            this.vibeTextBox.Location = new System.Drawing.Point(184, 172);
            this.vibeTextBox.Name = "vibeTextBox";
            this.vibeTextBox.Size = new System.Drawing.Size(209, 20);
            this.vibeTextBox.TabIndex = 8;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.themeBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(184, 198);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(209, 20);
            this.locationTextBox.TabIndex = 10;
            // 
            // emotional_StateTextBox
            // 
            this.emotional_StateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.themeBindingSource, "Emotional_State", true));
            this.emotional_StateTextBox.Location = new System.Drawing.Point(184, 224);
            this.emotional_StateTextBox.Name = "emotional_StateTextBox";
            this.emotional_StateTextBox.Size = new System.Drawing.Size(209, 20);
            this.emotional_StateTextBox.TabIndex = 12;
            // 
            // scientific_EvidenceTextBox
            // 
            this.scientific_EvidenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.themeBindingSource, "Scientific_Evidence", true));
            this.scientific_EvidenceTextBox.Location = new System.Drawing.Point(184, 250);
            this.scientific_EvidenceTextBox.Name = "scientific_EvidenceTextBox";
            this.scientific_EvidenceTextBox.Size = new System.Drawing.Size(209, 20);
            this.scientific_EvidenceTextBox.TabIndex = 14;
            // 
            // themeDataGridView
            // 
            this.themeDataGridView.AutoGenerateColumns = false;
            this.themeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.themeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.themeDataGridView.DataSource = this.themeBindingSource;
            this.themeDataGridView.Location = new System.Drawing.Point(495, 61);
            this.themeDataGridView.Name = "themeDataGridView";
            this.themeDataGridView.Size = new System.Drawing.Size(741, 220);
            this.themeDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ThemeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ThemeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ThemeName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ThemeName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nature";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nature";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Vibe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Vibe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Location";
            this.dataGridViewTextBoxColumn5.HeaderText = "Location";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Emotional_State";
            this.dataGridViewTextBoxColumn6.HeaderText = "Emotional_State";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Scientific_Evidence";
            this.dataGridViewTextBoxColumn7.HeaderText = "Scientific_Evidence";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(287, 351);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(66, 23);
            this.btncancel.TabIndex = 32;
            this.btncancel.Text = "Delete";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(184, 351);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(66, 23);
            this.btndelete.TabIndex = 31;
            this.btndelete.Text = "Save";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsavenow
            // 
            this.btnsavenow.Location = new System.Drawing.Point(82, 351);
            this.btnsavenow.Name = "btnsavenow";
            this.btnsavenow.Size = new System.Drawing.Size(66, 23);
            this.btnsavenow.TabIndex = 30;
            this.btnsavenow.Text = "Add New";
            this.btnsavenow.UseVisualStyleBackColor = true;
            this.btnsavenow.Click += new System.EventHandler(this.btnsavenow_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Creative_Ideas.Properties.Resources.Help;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(495, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Theme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Creative_Ideas.Properties.Resources.Theme;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1266, 415);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsavenow);
            this.Controls.Add(this.themeDataGridView);
            this.Controls.Add(themeIDLabel);
            this.Controls.Add(this.themeIDTextBox);
            this.Controls.Add(themeNameLabel);
            this.Controls.Add(this.themeNameTextBox);
            this.Controls.Add(natureLabel);
            this.Controls.Add(this.natureTextBox);
            this.Controls.Add(vibeLabel);
            this.Controls.Add(this.vibeTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(emotional_StateLabel);
            this.Controls.Add(this.emotional_StateTextBox);
            this.Controls.Add(scientific_EvidenceLabel);
            this.Controls.Add(this.scientific_EvidenceTextBox);
            this.Controls.Add(this.themeBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Theme";
            this.Text = "Theme";
            this.Load += new System.EventHandler(this.Theme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingNavigator)).EndInit();
            this.themeBindingNavigator.ResumeLayout(false);
            this.themeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.themeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreativeIdeasDataSet2 creativeIdeasDataSet2;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private CreativeIdeasDataSet2TableAdapters.ThemeTableAdapter themeTableAdapter;
        private CreativeIdeasDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator themeBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton themeBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox themeIDTextBox;
        private System.Windows.Forms.TextBox themeNameTextBox;
        private System.Windows.Forms.TextBox natureTextBox;
        private System.Windows.Forms.TextBox vibeTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox emotional_StateTextBox;
        private System.Windows.Forms.TextBox scientific_EvidenceTextBox;
        private System.Windows.Forms.DataGridView themeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsavenow;
        private System.Windows.Forms.Button button4;

    }
}