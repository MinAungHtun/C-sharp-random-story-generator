namespace Creative_Ideas
{
    partial class Action
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
            System.Windows.Forms.Label actionIDLabel;
            System.Windows.Forms.Label actionnLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Action));
            this.creativeIdeasDataSet2 = new Creative_Ideas.CreativeIdeasDataSet2();
            this.actBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actTableAdapter = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.ActTableAdapter();
            this.tableAdapterManager = new Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager();
            this.actBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.actBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.actionIDTextBox = new System.Windows.Forms.TextBox();
            this.actionnTextBox = new System.Windows.Forms.TextBox();
            this.actDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            actionIDLabel = new System.Windows.Forms.Label();
            actionnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingNavigator)).BeginInit();
            this.actBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actionIDLabel
            // 
            actionIDLabel.AutoSize = true;
            actionIDLabel.Location = new System.Drawing.Point(104, 130);
            actionIDLabel.Name = "actionIDLabel";
            actionIDLabel.Size = new System.Drawing.Size(54, 13);
            actionIDLabel.TabIndex = 1;
            actionIDLabel.Text = "Action ID:";
            // 
            // actionnLabel
            // 
            actionnLabel.AutoSize = true;
            actionnLabel.Location = new System.Drawing.Point(104, 156);
            actionnLabel.Name = "actionnLabel";
            actionnLabel.Size = new System.Drawing.Size(46, 13);
            actionnLabel.TabIndex = 3;
            actionnLabel.Text = "Actionn:";
            // 
            // creativeIdeasDataSet2
            // 
            this.creativeIdeasDataSet2.DataSetName = "CreativeIdeasDataSet2";
            this.creativeIdeasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actBindingSource
            // 
            this.actBindingSource.DataMember = "Act";
            this.actBindingSource.DataSource = this.creativeIdeasDataSet2;
            // 
            // actTableAdapter
            // 
            this.actTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountTableAdapter = null;
            this.tableAdapterManager.AccountTypeTableAdapter = null;
            this.tableAdapterManager.ActTableAdapter = this.actTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharactTableAdapter = null;
            this.tableAdapterManager.MotiveTableAdapter = null;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.ScriptTableAdapter = null;
            this.tableAdapterManager.ThemeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Creative_Ideas.CreativeIdeasDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actBindingNavigator
            // 
            this.actBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actBindingNavigator.BindingSource = this.actBindingSource;
            this.actBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.actBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.actBindingNavigatorSaveItem});
            this.actBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.actBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.actBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.actBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.actBindingNavigator.Name = "actBindingNavigator";
            this.actBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.actBindingNavigator.Size = new System.Drawing.Size(882, 25);
            this.actBindingNavigator.TabIndex = 0;
            this.actBindingNavigator.Text = "bindingNavigator1";
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
            // actBindingNavigatorSaveItem
            // 
            this.actBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actBindingNavigatorSaveItem.Image")));
            this.actBindingNavigatorSaveItem.Name = "actBindingNavigatorSaveItem";
            this.actBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.actBindingNavigatorSaveItem.Text = "Save Data";
            this.actBindingNavigatorSaveItem.Click += new System.EventHandler(this.actBindingNavigatorSaveItem_Click);
            // 
            // actionIDTextBox
            // 
            this.actionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actBindingSource, "ActionID", true));
            this.actionIDTextBox.Location = new System.Drawing.Point(164, 127);
            this.actionIDTextBox.Name = "actionIDTextBox";
            this.actionIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.actionIDTextBox.TabIndex = 2;
            // 
            // actionnTextBox
            // 
            this.actionnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actBindingSource, "Actionn", true));
            this.actionnTextBox.Location = new System.Drawing.Point(164, 153);
            this.actionnTextBox.Name = "actionnTextBox";
            this.actionnTextBox.Size = new System.Drawing.Size(192, 20);
            this.actionnTextBox.TabIndex = 4;
            // 
            // actDataGridView
            // 
            this.actDataGridView.AutoGenerateColumns = false;
            this.actDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.actDataGridView.DataSource = this.actBindingSource;
            this.actDataGridView.Location = new System.Drawing.Point(469, 77);
            this.actDataGridView.Name = "actDataGridView";
            this.actDataGridView.Size = new System.Drawing.Size(244, 220);
            this.actDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ActionID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ActionID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Actionn";
            this.dataGridViewTextBoxColumn2.HeaderText = "Actionn";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 41;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(156, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(57, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 23);
            this.button3.TabIndex = 39;
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
            this.button4.Location = new System.Drawing.Point(469, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Creative_Ideas.Properties.Resources.MotiveNAction;
            this.ClientSize = new System.Drawing.Size(882, 415);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.actDataGridView);
            this.Controls.Add(actionIDLabel);
            this.Controls.Add(this.actionIDTextBox);
            this.Controls.Add(actionnLabel);
            this.Controls.Add(this.actionnTextBox);
            this.Controls.Add(this.actBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Action";
            this.Text = "Action";
            this.Load += new System.EventHandler(this.Action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creativeIdeasDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actBindingNavigator)).EndInit();
            this.actBindingNavigator.ResumeLayout(false);
            this.actBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CreativeIdeasDataSet2 creativeIdeasDataSet2;
        private System.Windows.Forms.BindingSource actBindingSource;
        private CreativeIdeasDataSet2TableAdapters.ActTableAdapter actTableAdapter;
        private CreativeIdeasDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton actBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox actionIDTextBox;
        private System.Windows.Forms.TextBox actionnTextBox;
        private System.Windows.Forms.DataGridView actDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}