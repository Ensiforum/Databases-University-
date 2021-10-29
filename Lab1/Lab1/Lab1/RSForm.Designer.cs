
namespace Lab1
{
    partial class RSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSForm));
            System.Windows.Forms.Label kingdom_nameLabel;
            System.Windows.Forms.Label domain_nameLabel;
            System.Windows.Forms.Label fertilisation_typesLabel;
            this.biologistHandbookDataSet = new Lab1.BiologistHandbookDataSet();
            this.kingdomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kingdomTableAdapter = new Lab1.BiologistHandbookDataSetTableAdapters.kingdomTableAdapter();
            this.tableAdapterManager = new Lab1.BiologistHandbookDataSetTableAdapters.TableAdapterManager();
            this.kingdomBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.kingdomBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.kingdom_nameTextBox = new System.Windows.Forms.TextBox();
            this.domain_nameTextBox = new System.Windows.Forms.TextBox();
            this.fertilisation_typesTextBox = new System.Windows.Forms.TextBox();
            this.phylumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phylumTableAdapter = new Lab1.BiologistHandbookDataSetTableAdapters.phylumTableAdapter();
            this.phylumDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            kingdom_nameLabel = new System.Windows.Forms.Label();
            domain_nameLabel = new System.Windows.Forms.Label();
            fertilisation_typesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingNavigator)).BeginInit();
            this.kingdomBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phylumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phylumDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // biologistHandbookDataSet
            // 
            this.biologistHandbookDataSet.DataSetName = "BiologistHandbookDataSet";
            this.biologistHandbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kingdomBindingSource
            // 
            this.kingdomBindingSource.DataMember = "kingdom";
            this.kingdomBindingSource.DataSource = this.biologistHandbookDataSet;
            // 
            // kingdomTableAdapter
            // 
            this.kingdomTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.domainsTableAdapter = null;
            this.tableAdapterManager.kingdomTableAdapter = this.kingdomTableAdapter;
            this.tableAdapterManager.phylumTableAdapter = this.phylumTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab1.BiologistHandbookDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // kingdomBindingNavigator
            // 
            this.kingdomBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.kingdomBindingNavigator.BindingSource = this.kingdomBindingSource;
            this.kingdomBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.kingdomBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.kingdomBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.kingdomBindingNavigatorSaveItem});
            this.kingdomBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.kingdomBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.kingdomBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.kingdomBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.kingdomBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.kingdomBindingNavigator.Name = "kingdomBindingNavigator";
            this.kingdomBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.kingdomBindingNavigator.Size = new System.Drawing.Size(420, 25);
            this.kingdomBindingNavigator.TabIndex = 0;
            this.kingdomBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // kingdomBindingNavigatorSaveItem
            // 
            this.kingdomBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.kingdomBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("kingdomBindingNavigatorSaveItem.Image")));
            this.kingdomBindingNavigatorSaveItem.Name = "kingdomBindingNavigatorSaveItem";
            this.kingdomBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.kingdomBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.kingdomBindingNavigatorSaveItem.Click += new System.EventHandler(this.kingdomBindingNavigatorSaveItem_Click);
            // 
            // kingdom_nameLabel
            // 
            kingdom_nameLabel.AutoSize = true;
            kingdom_nameLabel.Location = new System.Drawing.Point(60, 67);
            kingdom_nameLabel.Name = "kingdom_nameLabel";
            kingdom_nameLabel.Size = new System.Drawing.Size(79, 13);
            kingdom_nameLabel.TabIndex = 1;
            kingdom_nameLabel.Text = "kingdom name:";
            // 
            // kingdom_nameTextBox
            // 
            this.kingdom_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kingdomBindingSource, "kingdom_name", true));
            this.kingdom_nameTextBox.Location = new System.Drawing.Point(153, 64);
            this.kingdom_nameTextBox.Name = "kingdom_nameTextBox";
            this.kingdom_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.kingdom_nameTextBox.TabIndex = 2;
            // 
            // domain_nameLabel
            // 
            domain_nameLabel.AutoSize = true;
            domain_nameLabel.Location = new System.Drawing.Point(60, 93);
            domain_nameLabel.Name = "domain_nameLabel";
            domain_nameLabel.Size = new System.Drawing.Size(73, 13);
            domain_nameLabel.TabIndex = 3;
            domain_nameLabel.Text = "domain name:";
            // 
            // domain_nameTextBox
            // 
            this.domain_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kingdomBindingSource, "domain_name", true));
            this.domain_nameTextBox.Location = new System.Drawing.Point(153, 90);
            this.domain_nameTextBox.Name = "domain_nameTextBox";
            this.domain_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.domain_nameTextBox.TabIndex = 4;
            // 
            // fertilisation_typesLabel
            // 
            fertilisation_typesLabel.AutoSize = true;
            fertilisation_typesLabel.Location = new System.Drawing.Point(60, 119);
            fertilisation_typesLabel.Name = "fertilisation_typesLabel";
            fertilisation_typesLabel.Size = new System.Drawing.Size(87, 13);
            fertilisation_typesLabel.TabIndex = 5;
            fertilisation_typesLabel.Text = "fertilisation types:";
            // 
            // fertilisation_typesTextBox
            // 
            this.fertilisation_typesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.kingdomBindingSource, "fertilisation_types", true));
            this.fertilisation_typesTextBox.Location = new System.Drawing.Point(153, 116);
            this.fertilisation_typesTextBox.Name = "fertilisation_typesTextBox";
            this.fertilisation_typesTextBox.Size = new System.Drawing.Size(100, 20);
            this.fertilisation_typesTextBox.TabIndex = 6;
            // 
            // phylumBindingSource
            // 
            this.phylumBindingSource.DataMember = "kingdomphylum";
            this.phylumBindingSource.DataSource = this.kingdomBindingSource;
            // 
            // phylumTableAdapter
            // 
            this.phylumTableAdapter.ClearBeforeFill = true;
            // 
            // phylumDataGridView
            // 
            this.phylumDataGridView.AutoGenerateColumns = false;
            this.phylumDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phylumDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.phylumDataGridView.DataSource = this.phylumBindingSource;
            this.phylumDataGridView.Location = new System.Drawing.Point(63, 177);
            this.phylumDataGridView.Name = "phylumDataGridView";
            this.phylumDataGridView.Size = new System.Drawing.Size(300, 220);
            this.phylumDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "phylum_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "phylum_name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "kingdom_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "kingdom_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "cellular_differentiation";
            this.dataGridViewCheckBoxColumn1.HeaderText = "cellular_differentiation";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Confirm changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phylumDataGridView);
            this.Controls.Add(kingdom_nameLabel);
            this.Controls.Add(this.kingdom_nameTextBox);
            this.Controls.Add(domain_nameLabel);
            this.Controls.Add(this.domain_nameTextBox);
            this.Controls.Add(fertilisation_typesLabel);
            this.Controls.Add(this.fertilisation_typesTextBox);
            this.Controls.Add(this.kingdomBindingNavigator);
            this.Name = "RSForm";
            this.Text = "RSForm";
            this.Load += new System.EventHandler(this.RSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingNavigator)).EndInit();
            this.kingdomBindingNavigator.ResumeLayout(false);
            this.kingdomBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phylumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phylumDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BiologistHandbookDataSet biologistHandbookDataSet;
        private System.Windows.Forms.BindingSource kingdomBindingSource;
        private BiologistHandbookDataSetTableAdapters.kingdomTableAdapter kingdomTableAdapter;
        private BiologistHandbookDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator kingdomBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton kingdomBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox kingdom_nameTextBox;
        private System.Windows.Forms.TextBox domain_nameTextBox;
        private System.Windows.Forms.TextBox fertilisation_typesTextBox;
        private BiologistHandbookDataSetTableAdapters.phylumTableAdapter phylumTableAdapter;
        private System.Windows.Forms.BindingSource phylumBindingSource;
        private System.Windows.Forms.DataGridView phylumDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button button1;
    }
}