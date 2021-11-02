using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class EditForm : Form
    {
        bool edit;
        public EditForm()
        {
            InitializeComponent();
            phylumTableAdapter.Fill(biologistHandbookDataSet1.phylum);
            kingdomTableAdapter.Fill(biologistHandbookDataSet1.kingdom);
            edit = false;
        }

        public EditForm(string phylumName, string kingdomName, bool cellDiff)
        {
            InitializeComponent();
            phylumTableAdapter.Fill(biologistHandbookDataSet1.phylum);
            kingdomTableAdapter.Fill(biologistHandbookDataSet1.kingdom);

            edit = true;
            phylumTextBox.Text = phylumName;
            var ind = kingdomComboBox.FindStringExact(kingdomName);
            kingdomComboBox.SelectedIndex = ind;
            cellDiffCheckBox.Checked = cellDiff;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet1.phylum". При необходимости она может быть перемещена или удалена.
            //this.phylumTableAdapter.Fill(this.biologistHandbookDataSet1.phylum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet1.kingdom". При необходимости она может быть перемещена или удалена.
            //this.kingdomTableAdapter.Fill(this.biologistHandbookDataSet1.kingdom);

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string phylumName = phylumTextBox.Text.ToString();
            string kingdomName = kingdomComboBox.GetItemText(kingdomComboBox.SelectedItem);
            bool cellDiff = cellDiffCheckBox.Checked;

            if(edit)
            {
                phylumTableAdapter.UpdateQuery(phylumName, kingdomName, cellDiff);
            }
            else
            {
                phylumTableAdapter.Insert(phylumName, kingdomName, cellDiff);
            }
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
