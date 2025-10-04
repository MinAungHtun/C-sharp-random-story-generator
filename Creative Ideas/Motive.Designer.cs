namespace Creative_Ideas
{
    partial class Motive
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
            System.Windows.Forms.Label motiveIDLabel;
            System.Windows.Forms.Label motiveNameLabel;
            System.Windows.Forms.Label descriptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motive));
            this.creativeIdeasDataSet2 = new Creative_Ideas.CreativeIdeasDataSet2();
            this.motiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.motiveTableAdapter = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.MotiveTableAdapter();
            this.tableAdapterManager = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager();
            this.motiveBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.motiveBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.motiveIDTextBox = new System.Windows.Forms.TextBox();
            this.motiveNameTextBox = new System.Windows.Forms.TextBox();
            this.descriptTextBox = new System.Windows.Forms.TextBox();
            this.motiveDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            motiveIDLabel = new System.Windows.Forms.Label();
            motiveNameLabel = new System.Windows.Forms.Label();
            descriptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motiveBindingNavigator)).BeginInit();
            this.motiveBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motiveDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // motiveIDLabel
            // 
            motiveIDLabel.AutoSize = true;
            motiveIDLabel.Location = new System.Drawing.Point(62, 118);
            motiveIDLabel.Name = "motiveIDLabel";
            motiveIDLabel.Size = new System.Drawing.Size(56, 13);
            motiveIDLabel.TabIndex = 30;
            motiveIDLabel.Text = "Motive ID:";
            // 
            // motiveNameLabel
            // 
            motiveNameLabel.AutoSize = true;
            motiveNameLabel.Location = new System.Drawing.Point(62, 144);
            motiveNameLabel.Name = "motiveNameLabel";
            motiveNameLabel.Size = new System.Drawing.Size(73, 13);
            motiveNameLabel.TabIndex = 32;
            motiveNameLabel.Text = "Motive Name:";
            // 
            // descriptLabel
            // 
            descriptLabel.AutoSize = true;
            descriptLabel.Location = new System.Drawing.Point(62, 170);
            descriptLabel.Name = "descriptLabel";
            descriptLabel.Size = new System.Drawing.Size(49, 13);
            descriptLabel.TabIndex = 34;
            descriptLabel.Text = "Descript:";
            // 
            // creativeIdeasDataSet2
            // 
            this.creativeIdeasDataSet2.DataSetName = "CreativeIdeasDataSet2";
            this.creativeIdeasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // motiveBindingSource
            // 
            this.motiveBindingSource.DataMember = "Motive";
            this.motiveBindingSource.DataSource = this.creativeIdeasDataSet2;
            // 
            // motiveTableAdapter
            // 
            this.motiveTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.ActTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharactTableAdapter = null;
            this.tableAdapterManager.MotiveTableAdapter = this.motiveTableAdapter;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.ScriptTableAdapter = null;
            this.tableAdapterManager.ThemeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // motiveBindingNavigator
            // 
            this.motiveBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.motiveBindingNavigator.BindingSource = this.motiveBindingSource;
            this.motiveBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.motiveBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.motiveBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.motiveBindingNavigatorSaveItem});
            this.motiveBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.motiveBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.motiveBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.motiveBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.motiveBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.motiveBindingNavigator.Name = "motiveBindingNavigator";
            this.motiveBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.motiveBindingNavigator.Size = new System.Drawing.Size(1029, 25);
            this.motiveBindingNavigator.TabIndex = 30;
            this.motiveBindingNavigator.Text = "bindingNavigator1";
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
            // motiveBindingNavigatorSaveItem
            // 
            this.motiveBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.motiveBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("motiveBindingNavigatorSaveItem.Image")));
            this.motiveBindingNavigatorSaveItem.Name = "motiveBindingNavigatorSaveItem";
            this.motiveBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.motiveBindingNavigatorSaveItem.Text = "Save Data";
            this.motiveBindingNavigatorSaveItem.Click += new System.EventHandler(this.motiveBindingNavigatorSaveItem_Click);
            // 
            // motiveIDTextBox
            // 
            this.motiveIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motiveBindingSource, "MotiveID", true));
            this.motiveIDTextBox.Location = new System.Drawing.Point(141, 115);
            this.motiveIDTextBox.Name = "motiveIDTextBox";
            this.motiveIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.motiveIDTextBox.TabIndex = 31;
            // 
            // motiveNameTextBox
            // 
            this.motiveNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motiveBindingSource, "MotiveName", true));
            this.motiveNameTextBox.Location = new System.Drawing.Point(141, 141);
            this.motiveNameTextBox.Name = "motiveNameTextBox";
            this.motiveNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.motiveNameTextBox.TabIndex = 33;
            // 
            // descriptTextBox
            // 
            this.descriptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.motiveBindingSource, "Descript", true));
            this.descriptTextBox.Location = new System.Drawing.Point(141, 167);
            this.descriptTextBox.Name = "descriptTextBox";
            this.descriptTextBox.Size = new System.Drawing.Size(171, 20);
            this.descriptTextBox.TabIndex = 35;
            // 
            // motiveDataGridView
            // 
            this.motiveDataGridView.AutoGenerateColumns = false;
            this.motiveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.motiveDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.motiveDataGridView.DataSource = this.motiveBindingSource;
            this.motiveDataGridView.Location = new System.Drawing.Point(391, 65);
            this.motiveDataGridView.Name = "motiveDataGridView";
            this.motiveDataGridView.Size = new System.Drawing.Size(342, 220);
            this.motiveDataGridView.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MotiveID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MotiveID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MotiveName";
            this.dataGridViewTextBoxColumn2.HeaderText = "MotiveName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descript";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descript";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(65, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Add New";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Creative_Ideas.Properties.Resources.Help;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(391, 291);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 43;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Motive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Creative_Ideas.Properties.Resources.MotiveNAction;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1029, 433);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.motiveDataGridView);
            this.Controls.Add(motiveIDLabel);
            this.Controls.Add(this.motiveIDTextBox);
            this.Controls.Add(motiveNameLabel);
            this.Controls.Add(this.motiveNameTextBox);
            this.Controls.Add(descriptLabel);
            this.Controls.Add(this.descriptTextBox);
            this.Controls.Add(this.motiveBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Motive";
            this.Text = "Motive ";
            this.Load += new System.EventHandler(this.Motive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motiveBindingNavigator)).EndInit();
            this.motiveBindingNavigator.ResumeLayout(false);
            this.motiveBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motiveDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreativeIdeasDataSet2 creativeIdeasDataSet2;
        private System.Windows.Forms.BindingSource motiveBindingSource;
        private CreativeIdeasDataSet2TableAdapters.MotiveTableAdapter motiveTableAdapter;
        private CreativeIdeasDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator motiveBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton motiveBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox motiveIDTextBox;
        private System.Windows.Forms.TextBox motiveNameTextBox;
        private System.Windows.Forms.TextBox descriptTextBox;
        private System.Windows.Forms.DataGridView motiveDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

    }
}