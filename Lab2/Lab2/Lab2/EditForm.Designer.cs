
namespace Lab1
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.phylumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kingdomComboBox = new System.Windows.Forms.ComboBox();
            this.kingdomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.biologistHandbookDataSet1 = new Lab1.BiologistHandbookDataSet1();
            this.cellDiffCheckBox = new System.Windows.Forms.CheckBox();
            this.kingdomTableAdapter = new Lab1.BiologistHandbookDataSet1TableAdapters.kingdomTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.phylumTableAdapter = new Lab1.BiologistHandbookDataSet1TableAdapters.phylumTableAdapter();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phylum";
            // 
            // phylumTextBox
            // 
            this.phylumTextBox.Location = new System.Drawing.Point(176, 54);
            this.phylumTextBox.Name = "phylumTextBox";
            this.phylumTextBox.Size = new System.Drawing.Size(100, 20);
            this.phylumTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kingdom";
            // 
            // kingdomComboBox
            // 
            this.kingdomComboBox.DataSource = this.kingdomBindingSource;
            this.kingdomComboBox.DisplayMember = "kingdom_name";
            this.kingdomComboBox.FormattingEnabled = true;
            this.kingdomComboBox.Location = new System.Drawing.Point(176, 119);
            this.kingdomComboBox.Name = "kingdomComboBox";
            this.kingdomComboBox.Size = new System.Drawing.Size(121, 21);
            this.kingdomComboBox.TabIndex = 3;
            this.kingdomComboBox.ValueMember = "kingdom_name";
            // 
            // kingdomBindingSource
            // 
            this.kingdomBindingSource.DataMember = "kingdom";
            this.kingdomBindingSource.DataSource = this.biologistHandbookDataSet1;
            // 
            // biologistHandbookDataSet1
            // 
            this.biologistHandbookDataSet1.DataSetName = "BiologistHandbookDataSet1";
            this.biologistHandbookDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cellDiffCheckBox
            // 
            this.cellDiffCheckBox.AutoSize = true;
            this.cellDiffCheckBox.Location = new System.Drawing.Point(41, 182);
            this.cellDiffCheckBox.Name = "cellDiffCheckBox";
            this.cellDiffCheckBox.Size = new System.Drawing.Size(126, 17);
            this.cellDiffCheckBox.TabIndex = 4;
            this.cellDiffCheckBox.Text = "Cellular differentiation";
            this.cellDiffCheckBox.UseVisualStyleBackColor = true;
            // 
            // kingdomTableAdapter
            // 
            this.kingdomTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "phylum";
            this.bindingSource1.DataSource = this.biologistHandbookDataSet1;
            // 
            // phylumTableAdapter
            // 
            this.phylumTableAdapter.ClearBeforeFill = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(41, 255);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(126, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(176, 255);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(121, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 290);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cellDiffCheckBox);
            this.Controls.Add(this.kingdomComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.phylumTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kingdomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biologistHandbookDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phylumTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox kingdomComboBox;
        private System.Windows.Forms.CheckBox cellDiffCheckBox;
        private BiologistHandbookDataSet1 biologistHandbookDataSet1;
        private System.Windows.Forms.BindingSource kingdomBindingSource;
        private BiologistHandbookDataSet1TableAdapters.kingdomTableAdapter kingdomTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BiologistHandbookDataSet1TableAdapters.phylumTableAdapter phylumTableAdapter;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
    }
}