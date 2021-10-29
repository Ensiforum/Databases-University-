
namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.biologistHandbookDataSet = new Lab1.BiologistHandbookDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.domainnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nucleuspresenceDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.domainsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domainsTableAdapter = new Lab1.BiologistHandbookDataSetTableAdapters.domainsTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kingdomnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertilisationtypesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kingdomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kingdomTableAdapter = new Lab1.BiologistHandbookDataSetTableAdapters.kingdomTableAdapter();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.phylumnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kingdomnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellulardifferentiationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.phylumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phylumTableAdapter = new Lab1.BiologistHandbookDataSetTableAdapters.phylumTableAdapter();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kingdomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phylumsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resettlementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bindingNavigator6 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem5 = new System.Windows.Forms.ToolStripButton();
            this.phylumBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.biologistHandbookDataSet1 = new Lab1.BiologistHandbookDataSet1();
            this.bindingNavigatorCountItem5 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem5 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem5 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.phylumnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kingdomnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellulardifferentiationDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem4 = new System.Windows.Forms.ToolStripButton();
            this.kingdomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem4 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem4 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem4 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.kingdomnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domainnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertilisationtypesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem3 = new System.Windows.Forms.ToolStripButton();
            this.domainsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem3 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem3 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem3 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.domainnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nucleuspresenceDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.bindingNavigator7 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem6 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem6 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem6 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.domainsTableAdapter1 = new Lab1.BiologistHandbookDataSet1TableAdapters.domainsTableAdapter();
            this.kingdomTableAdapter1 = new Lab1.BiologistHandbookDataSet1TableAdapters.kingdomTableAdapter();
            this.phylumTableAdapter1 = new Lab1.BiologistHandbookDataSet1TableAdapters.phylumTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phylumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).BeginInit();
            this.bindingNavigator6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phylumBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator7)).BeginInit();
            this.bindingNavigator7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.biologistHandbookDataSet;
            this.bindingSource1.Position = 0;
            // 
            // biologistHandbookDataSet
            // 
            this.biologistHandbookDataSet.DataSetName = "BiologistHandbookDataSet";
            this.biologistHandbookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domainnameDataGridViewTextBoxColumn,
            this.nucleuspresenceDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.domainsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // domainnameDataGridViewTextBoxColumn
            // 
            this.domainnameDataGridViewTextBoxColumn.DataPropertyName = "domain_name";
            this.domainnameDataGridViewTextBoxColumn.HeaderText = "domain_name";
            this.domainnameDataGridViewTextBoxColumn.Name = "domainnameDataGridViewTextBoxColumn";
            // 
            // nucleuspresenceDataGridViewCheckBoxColumn
            // 
            this.nucleuspresenceDataGridViewCheckBoxColumn.DataPropertyName = "nucleus_presence";
            this.nucleuspresenceDataGridViewCheckBoxColumn.HeaderText = "nucleus_presence";
            this.nucleuspresenceDataGridViewCheckBoxColumn.Name = "nucleuspresenceDataGridViewCheckBoxColumn";
            // 
            // domainsBindingSource
            // 
            this.domainsBindingSource.DataMember = "domains";
            this.domainsBindingSource.DataSource = this.bindingSource1;
            // 
            // domainsTableAdapter
            // 
            this.domainsTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.domainsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 153);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kingdomnameDataGridViewTextBoxColumn,
            this.domainnameDataGridViewTextBoxColumn1,
            this.fertilisationtypesDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.kingdomBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 178);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(786, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // kingdomnameDataGridViewTextBoxColumn
            // 
            this.kingdomnameDataGridViewTextBoxColumn.DataPropertyName = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn.HeaderText = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn.Name = "kingdomnameDataGridViewTextBoxColumn";
            // 
            // domainnameDataGridViewTextBoxColumn1
            // 
            this.domainnameDataGridViewTextBoxColumn1.DataPropertyName = "domain_name";
            this.domainnameDataGridViewTextBoxColumn1.HeaderText = "domain_name";
            this.domainnameDataGridViewTextBoxColumn1.Name = "domainnameDataGridViewTextBoxColumn1";
            // 
            // fertilisationtypesDataGridViewTextBoxColumn
            // 
            this.fertilisationtypesDataGridViewTextBoxColumn.DataPropertyName = "fertilisation_types";
            this.fertilisationtypesDataGridViewTextBoxColumn.HeaderText = "fertilisation_types";
            this.fertilisationtypesDataGridViewTextBoxColumn.Name = "fertilisationtypesDataGridViewTextBoxColumn";
            // 
            // kingdomBindingSource
            // 
            this.kingdomBindingSource.DataMember = "kingdom";
            this.kingdomBindingSource.DataSource = this.bindingSource1;
            // 
            // kingdomTableAdapter
            // 
            this.kingdomTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.kingdomBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 328);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator2.TabIndex = 3;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phylumnameDataGridViewTextBoxColumn,
            this.kingdomnameDataGridViewTextBoxColumn1,
            this.cellulardifferentiationDataGridViewCheckBoxColumn});
            this.dataGridView3.DataSource = this.phylumBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(3, 353);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(786, 150);
            this.dataGridView3.TabIndex = 4;
            // 
            // phylumnameDataGridViewTextBoxColumn
            // 
            this.phylumnameDataGridViewTextBoxColumn.DataPropertyName = "phylum_name";
            this.phylumnameDataGridViewTextBoxColumn.HeaderText = "phylum_name";
            this.phylumnameDataGridViewTextBoxColumn.Name = "phylumnameDataGridViewTextBoxColumn";
            // 
            // kingdomnameDataGridViewTextBoxColumn1
            // 
            this.kingdomnameDataGridViewTextBoxColumn1.DataPropertyName = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn1.HeaderText = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn1.Name = "kingdomnameDataGridViewTextBoxColumn1";
            // 
            // cellulardifferentiationDataGridViewCheckBoxColumn
            // 
            this.cellulardifferentiationDataGridViewCheckBoxColumn.DataPropertyName = "cellular_differentiation";
            this.cellulardifferentiationDataGridViewCheckBoxColumn.HeaderText = "cellular_differentiation";
            this.cellulardifferentiationDataGridViewCheckBoxColumn.Name = "cellulardifferentiationDataGridViewCheckBoxColumn";
            // 
            // phylumBindingSource
            // 
            this.phylumBindingSource.DataMember = "phylum";
            this.phylumBindingSource.DataSource = this.bindingSource1;
            // 
            // phylumTableAdapter
            // 
            this.phylumTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.phylumBindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 503);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator3.TabIndex = 5;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem2";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem2.Text = "Добавить";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem2";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem2.Text = "для {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem2";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem2.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem2";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem2.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem2";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem2.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator6";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem2";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator7";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem2";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem2.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem2";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem2.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator8";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domainsToolStripMenuItem,
            this.kingdomsToolStripMenuItem,
            this.phylumsToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // domainsToolStripMenuItem
            // 
            this.domainsToolStripMenuItem.Name = "domainsToolStripMenuItem";
            this.domainsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.domainsToolStripMenuItem.Text = "Domains";
            this.domainsToolStripMenuItem.Click += new System.EventHandler(this.domainsToolStripMenuItem_Click);
            // 
            // kingdomsToolStripMenuItem
            // 
            this.kingdomsToolStripMenuItem.Name = "kingdomsToolStripMenuItem";
            this.kingdomsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.kingdomsToolStripMenuItem.Text = "Kingdoms";
            this.kingdomsToolStripMenuItem.Click += new System.EventHandler(this.kingdomsToolStripMenuItem_Click);
            // 
            // phylumsToolStripMenuItem
            // 
            this.phylumsToolStripMenuItem.Name = "phylumsToolStripMenuItem";
            this.phylumsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.phylumsToolStripMenuItem.Text = "Phylums";
            this.phylumsToolStripMenuItem.Click += new System.EventHandler(this.phylumsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resettlementToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // resettlementToolStripMenuItem
            // 
            this.resettlementToolStripMenuItem.Name = "resettlementToolStripMenuItem";
            this.resettlementToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.resettlementToolStripMenuItem.Text = "Resettlement";
            this.resettlementToolStripMenuItem.Click += new System.EventHandler(this.resettlementToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 576);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bindingNavigator3);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.bindingNavigator2);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 550);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MS Access";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bindingNavigator6);
            this.tabPage2.Controls.Add(this.dataGridView6);
            this.tabPage2.Controls.Add(this.bindingNavigator5);
            this.tabPage2.Controls.Add(this.dataGridView5);
            this.tabPage2.Controls.Add(this.bindingNavigator4);
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 550);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MS SQL Server";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator6
            // 
            this.bindingNavigator6.AddNewItem = this.bindingNavigatorAddNewItem5;
            this.bindingNavigator6.BindingSource = this.phylumBindingSource1;
            this.bindingNavigator6.CountItem = this.bindingNavigatorCountItem5;
            this.bindingNavigator6.DeleteItem = this.bindingNavigatorDeleteItem5;
            this.bindingNavigator6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem5,
            this.bindingNavigatorMovePreviousItem5,
            this.bindingNavigatorSeparator15,
            this.bindingNavigatorPositionItem5,
            this.bindingNavigatorCountItem5,
            this.bindingNavigatorSeparator16,
            this.bindingNavigatorMoveNextItem5,
            this.bindingNavigatorMoveLastItem5,
            this.bindingNavigatorSeparator17,
            this.bindingNavigatorAddNewItem5,
            this.bindingNavigatorDeleteItem5});
            this.bindingNavigator6.Location = new System.Drawing.Point(3, 503);
            this.bindingNavigator6.MoveFirstItem = this.bindingNavigatorMoveFirstItem5;
            this.bindingNavigator6.MoveLastItem = this.bindingNavigatorMoveLastItem5;
            this.bindingNavigator6.MoveNextItem = this.bindingNavigatorMoveNextItem5;
            this.bindingNavigator6.MovePreviousItem = this.bindingNavigatorMovePreviousItem5;
            this.bindingNavigator6.Name = "bindingNavigator6";
            this.bindingNavigator6.PositionItem = this.bindingNavigatorPositionItem5;
            this.bindingNavigator6.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator6.TabIndex = 5;
            this.bindingNavigator6.Text = "bindingNavigator6";
            // 
            // bindingNavigatorAddNewItem5
            // 
            this.bindingNavigatorAddNewItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem5.Image")));
            this.bindingNavigatorAddNewItem5.Name = "bindingNavigatorAddNewItem5";
            this.bindingNavigatorAddNewItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem5.Text = "Добавить";
            // 
            // phylumBindingSource1
            // 
            this.phylumBindingSource1.DataMember = "phylum";
            this.phylumBindingSource1.DataSource = this.bindingSource2;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataSource = this.biologistHandbookDataSet1;
            this.bindingSource2.Position = 0;
            // 
            // biologistHandbookDataSet1
            // 
            this.biologistHandbookDataSet1.DataSetName = "BiologistHandbookDataSet1";
            this.biologistHandbookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem5
            // 
            this.bindingNavigatorCountItem5.Name = "bindingNavigatorCountItem5";
            this.bindingNavigatorCountItem5.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem5.Text = "для {0}";
            this.bindingNavigatorCountItem5.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem5
            // 
            this.bindingNavigatorDeleteItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem5.Image")));
            this.bindingNavigatorDeleteItem5.Name = "bindingNavigatorDeleteItem5";
            this.bindingNavigatorDeleteItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem5.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem5
            // 
            this.bindingNavigatorMoveFirstItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem5.Image")));
            this.bindingNavigatorMoveFirstItem5.Name = "bindingNavigatorMoveFirstItem5";
            this.bindingNavigatorMoveFirstItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem5.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem5
            // 
            this.bindingNavigatorMovePreviousItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem5.Image")));
            this.bindingNavigatorMovePreviousItem5.Name = "bindingNavigatorMovePreviousItem5";
            this.bindingNavigatorMovePreviousItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem5.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator15
            // 
            this.bindingNavigatorSeparator15.Name = "bindingNavigatorSeparator15";
            this.bindingNavigatorSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem5
            // 
            this.bindingNavigatorPositionItem5.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem5.AutoSize = false;
            this.bindingNavigatorPositionItem5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem5.Name = "bindingNavigatorPositionItem5";
            this.bindingNavigatorPositionItem5.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem5.Text = "0";
            this.bindingNavigatorPositionItem5.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator16
            // 
            this.bindingNavigatorSeparator16.Name = "bindingNavigatorSeparator16";
            this.bindingNavigatorSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem5
            // 
            this.bindingNavigatorMoveNextItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem5.Image")));
            this.bindingNavigatorMoveNextItem5.Name = "bindingNavigatorMoveNextItem5";
            this.bindingNavigatorMoveNextItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem5.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem5
            // 
            this.bindingNavigatorMoveLastItem5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem5.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem5.Image")));
            this.bindingNavigatorMoveLastItem5.Name = "bindingNavigatorMoveLastItem5";
            this.bindingNavigatorMoveLastItem5.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem5.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem5.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator17
            // 
            this.bindingNavigatorSeparator17.Name = "bindingNavigatorSeparator17";
            this.bindingNavigatorSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phylumnameDataGridViewTextBoxColumn1,
            this.kingdomnameDataGridViewTextBoxColumn3,
            this.cellulardifferentiationDataGridViewCheckBoxColumn1});
            this.dataGridView6.DataSource = this.phylumBindingSource1;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView6.Location = new System.Drawing.Point(3, 353);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(786, 150);
            this.dataGridView6.TabIndex = 4;
            // 
            // phylumnameDataGridViewTextBoxColumn1
            // 
            this.phylumnameDataGridViewTextBoxColumn1.DataPropertyName = "phylum_name";
            this.phylumnameDataGridViewTextBoxColumn1.HeaderText = "phylum_name";
            this.phylumnameDataGridViewTextBoxColumn1.Name = "phylumnameDataGridViewTextBoxColumn1";
            // 
            // kingdomnameDataGridViewTextBoxColumn3
            // 
            this.kingdomnameDataGridViewTextBoxColumn3.DataPropertyName = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn3.HeaderText = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn3.Name = "kingdomnameDataGridViewTextBoxColumn3";
            // 
            // cellulardifferentiationDataGridViewCheckBoxColumn1
            // 
            this.cellulardifferentiationDataGridViewCheckBoxColumn1.DataPropertyName = "cellular_differentiation";
            this.cellulardifferentiationDataGridViewCheckBoxColumn1.HeaderText = "cellular_differentiation";
            this.cellulardifferentiationDataGridViewCheckBoxColumn1.Name = "cellulardifferentiationDataGridViewCheckBoxColumn1";
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.bindingNavigatorAddNewItem4;
            this.bindingNavigator5.BindingSource = this.kingdomBindingSource1;
            this.bindingNavigator5.CountItem = this.bindingNavigatorCountItem4;
            this.bindingNavigator5.DeleteItem = this.bindingNavigatorDeleteItem4;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem4,
            this.bindingNavigatorMovePreviousItem4,
            this.bindingNavigatorSeparator12,
            this.bindingNavigatorPositionItem4,
            this.bindingNavigatorCountItem4,
            this.bindingNavigatorSeparator13,
            this.bindingNavigatorMoveNextItem4,
            this.bindingNavigatorMoveLastItem4,
            this.bindingNavigatorSeparator14,
            this.bindingNavigatorAddNewItem4,
            this.bindingNavigatorDeleteItem4});
            this.bindingNavigator5.Location = new System.Drawing.Point(3, 328);
            this.bindingNavigator5.MoveFirstItem = this.bindingNavigatorMoveFirstItem4;
            this.bindingNavigator5.MoveLastItem = this.bindingNavigatorMoveLastItem4;
            this.bindingNavigator5.MoveNextItem = this.bindingNavigatorMoveNextItem4;
            this.bindingNavigator5.MovePreviousItem = this.bindingNavigatorMovePreviousItem4;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.bindingNavigatorPositionItem4;
            this.bindingNavigator5.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator5.TabIndex = 3;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // bindingNavigatorAddNewItem4
            // 
            this.bindingNavigatorAddNewItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem4.Image")));
            this.bindingNavigatorAddNewItem4.Name = "bindingNavigatorAddNewItem4";
            this.bindingNavigatorAddNewItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem4.Text = "Добавить";
            // 
            // kingdomBindingSource1
            // 
            this.kingdomBindingSource1.DataMember = "kingdom";
            this.kingdomBindingSource1.DataSource = this.bindingSource2;
            // 
            // bindingNavigatorCountItem4
            // 
            this.bindingNavigatorCountItem4.Name = "bindingNavigatorCountItem4";
            this.bindingNavigatorCountItem4.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem4.Text = "для {0}";
            this.bindingNavigatorCountItem4.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem4
            // 
            this.bindingNavigatorDeleteItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem4.Image")));
            this.bindingNavigatorDeleteItem4.Name = "bindingNavigatorDeleteItem4";
            this.bindingNavigatorDeleteItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem4.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem4
            // 
            this.bindingNavigatorMoveFirstItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem4.Image")));
            this.bindingNavigatorMoveFirstItem4.Name = "bindingNavigatorMoveFirstItem4";
            this.bindingNavigatorMoveFirstItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem4.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem4
            // 
            this.bindingNavigatorMovePreviousItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem4.Image")));
            this.bindingNavigatorMovePreviousItem4.Name = "bindingNavigatorMovePreviousItem4";
            this.bindingNavigatorMovePreviousItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem4.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator12
            // 
            this.bindingNavigatorSeparator12.Name = "bindingNavigatorSeparator12";
            this.bindingNavigatorSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem4
            // 
            this.bindingNavigatorPositionItem4.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem4.AutoSize = false;
            this.bindingNavigatorPositionItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem4.Name = "bindingNavigatorPositionItem4";
            this.bindingNavigatorPositionItem4.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem4.Text = "0";
            this.bindingNavigatorPositionItem4.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator13
            // 
            this.bindingNavigatorSeparator13.Name = "bindingNavigatorSeparator13";
            this.bindingNavigatorSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem4
            // 
            this.bindingNavigatorMoveNextItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem4.Image")));
            this.bindingNavigatorMoveNextItem4.Name = "bindingNavigatorMoveNextItem4";
            this.bindingNavigatorMoveNextItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem4.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem4
            // 
            this.bindingNavigatorMoveLastItem4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem4.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem4.Image")));
            this.bindingNavigatorMoveLastItem4.Name = "bindingNavigatorMoveLastItem4";
            this.bindingNavigatorMoveLastItem4.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem4.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem4.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator14
            // 
            this.bindingNavigatorSeparator14.Name = "bindingNavigatorSeparator14";
            this.bindingNavigatorSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kingdomnameDataGridViewTextBoxColumn2,
            this.domainnameDataGridViewTextBoxColumn3,
            this.fertilisationtypesDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.kingdomBindingSource1;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView5.Location = new System.Drawing.Point(3, 178);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(786, 150);
            this.dataGridView5.TabIndex = 2;
            // 
            // kingdomnameDataGridViewTextBoxColumn2
            // 
            this.kingdomnameDataGridViewTextBoxColumn2.DataPropertyName = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn2.HeaderText = "kingdom_name";
            this.kingdomnameDataGridViewTextBoxColumn2.Name = "kingdomnameDataGridViewTextBoxColumn2";
            // 
            // domainnameDataGridViewTextBoxColumn3
            // 
            this.domainnameDataGridViewTextBoxColumn3.DataPropertyName = "domain_name";
            this.domainnameDataGridViewTextBoxColumn3.HeaderText = "domain_name";
            this.domainnameDataGridViewTextBoxColumn3.Name = "domainnameDataGridViewTextBoxColumn3";
            // 
            // fertilisationtypesDataGridViewTextBoxColumn1
            // 
            this.fertilisationtypesDataGridViewTextBoxColumn1.DataPropertyName = "fertilisation_types";
            this.fertilisationtypesDataGridViewTextBoxColumn1.HeaderText = "fertilisation_types";
            this.fertilisationtypesDataGridViewTextBoxColumn1.Name = "fertilisationtypesDataGridViewTextBoxColumn1";
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.bindingNavigatorAddNewItem3;
            this.bindingNavigator4.BindingSource = this.domainsBindingSource1;
            this.bindingNavigator4.CountItem = this.bindingNavigatorCountItem3;
            this.bindingNavigator4.DeleteItem = this.bindingNavigatorDeleteItem3;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem3,
            this.bindingNavigatorMovePreviousItem3,
            this.bindingNavigatorSeparator9,
            this.bindingNavigatorPositionItem3,
            this.bindingNavigatorCountItem3,
            this.bindingNavigatorSeparator10,
            this.bindingNavigatorMoveNextItem3,
            this.bindingNavigatorMoveLastItem3,
            this.bindingNavigatorSeparator11,
            this.bindingNavigatorAddNewItem3,
            this.bindingNavigatorDeleteItem3});
            this.bindingNavigator4.Location = new System.Drawing.Point(3, 153);
            this.bindingNavigator4.MoveFirstItem = this.bindingNavigatorMoveFirstItem3;
            this.bindingNavigator4.MoveLastItem = this.bindingNavigatorMoveLastItem3;
            this.bindingNavigator4.MoveNextItem = this.bindingNavigatorMoveNextItem3;
            this.bindingNavigator4.MovePreviousItem = this.bindingNavigatorMovePreviousItem3;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.bindingNavigatorPositionItem3;
            this.bindingNavigator4.Size = new System.Drawing.Size(786, 25);
            this.bindingNavigator4.TabIndex = 1;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // bindingNavigatorAddNewItem3
            // 
            this.bindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem3.Image")));
            this.bindingNavigatorAddNewItem3.Name = "bindingNavigatorAddNewItem3";
            this.bindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem3.Text = "Добавить";
            // 
            // domainsBindingSource1
            // 
            this.domainsBindingSource1.DataMember = "domains";
            this.domainsBindingSource1.DataSource = this.bindingSource2;
            // 
            // bindingNavigatorCountItem3
            // 
            this.bindingNavigatorCountItem3.Name = "bindingNavigatorCountItem3";
            this.bindingNavigatorCountItem3.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem3.Text = "для {0}";
            this.bindingNavigatorCountItem3.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem3
            // 
            this.bindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem3.Image")));
            this.bindingNavigatorDeleteItem3.Name = "bindingNavigatorDeleteItem3";
            this.bindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem3.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem3
            // 
            this.bindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem3.Image")));
            this.bindingNavigatorMoveFirstItem3.Name = "bindingNavigatorMoveFirstItem3";
            this.bindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem3.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem3
            // 
            this.bindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem3.Image")));
            this.bindingNavigatorMovePreviousItem3.Name = "bindingNavigatorMovePreviousItem3";
            this.bindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem3.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator9
            // 
            this.bindingNavigatorSeparator9.Name = "bindingNavigatorSeparator9";
            this.bindingNavigatorSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem3
            // 
            this.bindingNavigatorPositionItem3.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem3.AutoSize = false;
            this.bindingNavigatorPositionItem3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem3.Name = "bindingNavigatorPositionItem3";
            this.bindingNavigatorPositionItem3.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem3.Text = "0";
            this.bindingNavigatorPositionItem3.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator10
            // 
            this.bindingNavigatorSeparator10.Name = "bindingNavigatorSeparator10";
            this.bindingNavigatorSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem3
            // 
            this.bindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem3.Image")));
            this.bindingNavigatorMoveNextItem3.Name = "bindingNavigatorMoveNextItem3";
            this.bindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem3.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem3
            // 
            this.bindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem3.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem3.Image")));
            this.bindingNavigatorMoveLastItem3.Name = "bindingNavigatorMoveLastItem3";
            this.bindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem3.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem3.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator11
            // 
            this.bindingNavigatorSeparator11.Name = "bindingNavigatorSeparator11";
            this.bindingNavigatorSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.domainnameDataGridViewTextBoxColumn2,
            this.nucleuspresenceDataGridViewCheckBoxColumn1});
            this.dataGridView4.DataSource = this.domainsBindingSource1;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(786, 150);
            this.dataGridView4.TabIndex = 0;
            // 
            // domainnameDataGridViewTextBoxColumn2
            // 
            this.domainnameDataGridViewTextBoxColumn2.DataPropertyName = "domain_name";
            this.domainnameDataGridViewTextBoxColumn2.HeaderText = "domain_name";
            this.domainnameDataGridViewTextBoxColumn2.Name = "domainnameDataGridViewTextBoxColumn2";
            // 
            // nucleuspresenceDataGridViewCheckBoxColumn1
            // 
            this.nucleuspresenceDataGridViewCheckBoxColumn1.DataPropertyName = "nucleus_presence";
            this.nucleuspresenceDataGridViewCheckBoxColumn1.HeaderText = "nucleus_presence";
            this.nucleuspresenceDataGridViewCheckBoxColumn1.Name = "nucleuspresenceDataGridViewCheckBoxColumn1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.bindingNavigator7);
            this.tabPage3.Controls.Add(this.dataGridView7);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 550);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Choose source";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator7
            // 
            this.bindingNavigator7.AddNewItem = this.bindingNavigatorAddNewItem6;
            this.bindingNavigator7.CountItem = this.bindingNavigatorCountItem6;
            this.bindingNavigator7.DeleteItem = this.bindingNavigatorDeleteItem6;
            this.bindingNavigator7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem6,
            this.bindingNavigatorMovePreviousItem6,
            this.bindingNavigatorSeparator18,
            this.bindingNavigatorPositionItem6,
            this.bindingNavigatorCountItem6,
            this.bindingNavigatorSeparator19,
            this.bindingNavigatorMoveNextItem6,
            this.bindingNavigatorMoveLastItem6,
            this.bindingNavigatorSeparator20,
            this.bindingNavigatorAddNewItem6,
            this.bindingNavigatorDeleteItem6});
            this.bindingNavigator7.Location = new System.Drawing.Point(0, 174);
            this.bindingNavigator7.MoveFirstItem = this.bindingNavigatorMoveFirstItem6;
            this.bindingNavigator7.MoveLastItem = this.bindingNavigatorMoveLastItem6;
            this.bindingNavigator7.MoveNextItem = this.bindingNavigatorMoveNextItem6;
            this.bindingNavigator7.MovePreviousItem = this.bindingNavigatorMovePreviousItem6;
            this.bindingNavigator7.Name = "bindingNavigator7";
            this.bindingNavigator7.PositionItem = this.bindingNavigatorPositionItem6;
            this.bindingNavigator7.Size = new System.Drawing.Size(792, 25);
            this.bindingNavigator7.TabIndex = 2;
            this.bindingNavigator7.Text = "bindingNavigator7";
            // 
            // bindingNavigatorAddNewItem6
            // 
            this.bindingNavigatorAddNewItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem6.Image")));
            this.bindingNavigatorAddNewItem6.Name = "bindingNavigatorAddNewItem6";
            this.bindingNavigatorAddNewItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem6.Text = "Добавить";
            // 
            // bindingNavigatorCountItem6
            // 
            this.bindingNavigatorCountItem6.Name = "bindingNavigatorCountItem6";
            this.bindingNavigatorCountItem6.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem6.Text = "для {0}";
            this.bindingNavigatorCountItem6.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem6
            // 
            this.bindingNavigatorDeleteItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem6.Image")));
            this.bindingNavigatorDeleteItem6.Name = "bindingNavigatorDeleteItem6";
            this.bindingNavigatorDeleteItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem6.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem6
            // 
            this.bindingNavigatorMoveFirstItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem6.Image")));
            this.bindingNavigatorMoveFirstItem6.Name = "bindingNavigatorMoveFirstItem6";
            this.bindingNavigatorMoveFirstItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem6.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem6
            // 
            this.bindingNavigatorMovePreviousItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem6.Image")));
            this.bindingNavigatorMovePreviousItem6.Name = "bindingNavigatorMovePreviousItem6";
            this.bindingNavigatorMovePreviousItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem6.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator18
            // 
            this.bindingNavigatorSeparator18.Name = "bindingNavigatorSeparator18";
            this.bindingNavigatorSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem6
            // 
            this.bindingNavigatorPositionItem6.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem6.AutoSize = false;
            this.bindingNavigatorPositionItem6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem6.Name = "bindingNavigatorPositionItem6";
            this.bindingNavigatorPositionItem6.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem6.Text = "0";
            this.bindingNavigatorPositionItem6.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator19
            // 
            this.bindingNavigatorSeparator19.Name = "bindingNavigatorSeparator19";
            this.bindingNavigatorSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem6
            // 
            this.bindingNavigatorMoveNextItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem6.Image")));
            this.bindingNavigatorMoveNextItem6.Name = "bindingNavigatorMoveNextItem6";
            this.bindingNavigatorMoveNextItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem6.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem6
            // 
            this.bindingNavigatorMoveLastItem6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem6.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem6.Image")));
            this.bindingNavigatorMoveLastItem6.Name = "bindingNavigatorMoveLastItem6";
            this.bindingNavigatorMoveLastItem6.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem6.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem6.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator20
            // 
            this.bindingNavigatorSeparator20.Name = "bindingNavigatorSeparator20";
            this.bindingNavigatorSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView7.Location = new System.Drawing.Point(0, 24);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(792, 150);
            this.dataGridView7.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load a database...";
            // 
            // domainsTableAdapter1
            // 
            this.domainsTableAdapter1.ClearBeforeFill = true;
            // 
            // kingdomTableAdapter1
            // 
            this.kingdomTableAdapter1.ClearBeforeFill = true;
            // 
            // phylumTableAdapter1
            // 
            this.phylumTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phylumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator6)).EndInit();
            this.bindingNavigator6.ResumeLayout(false);
            this.bindingNavigator6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phylumBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domainsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator7)).EndInit();
            this.bindingNavigator7.ResumeLayout(false);
            this.bindingNavigator7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private BiologistHandbookDataSet biologistHandbookDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource domainsBindingSource;
        private BiologistHandbookDataSetTableAdapters.domainsTableAdapter domainsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nucleuspresenceDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource kingdomBindingSource;
        private BiologistHandbookDataSetTableAdapters.kingdomTableAdapter kingdomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingdomnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertilisationtypesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource phylumBindingSource;
        private BiologistHandbookDataSetTableAdapters.phylumTableAdapter phylumTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn phylumnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingdomnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cellulardifferentiationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private BiologistHandbookDataSet1 biologistHandbookDataSet1;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.BindingSource domainsBindingSource1;
        private BiologistHandbookDataSet1TableAdapters.domainsTableAdapter domainsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem3;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator9;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator10;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem3;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator11;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nucleuspresenceDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.BindingSource kingdomBindingSource1;
        private BiologistHandbookDataSet1TableAdapters.kingdomTableAdapter kingdomTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem4;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator12;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator13;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem4;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator14;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingdomnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn domainnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertilisationtypesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource phylumBindingSource1;
        private BiologistHandbookDataSet1TableAdapters.phylumTableAdapter phylumTableAdapter1;
        private System.Windows.Forms.BindingNavigator bindingNavigator6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem5;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator15;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator16;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem5;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem5;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator17;
        private System.Windows.Forms.DataGridViewTextBoxColumn phylumnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kingdomnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cellulardifferentiationDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domainsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kingdomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phylumsToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem6;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator18;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator19;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem6;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem6;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator20;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resettlementToolStripMenuItem;
    }
}

