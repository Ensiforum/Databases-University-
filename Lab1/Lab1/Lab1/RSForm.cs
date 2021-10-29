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
    public partial class RSForm : Form
    {
        public RSForm()
        {
            InitializeComponent();
        }

        private void kingdomBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kingdomBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.biologistHandbookDataSet);

        }

        private void RSForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.phylum". При необходимости она может быть перемещена или удалена.
            this.phylumTableAdapter.Fill(this.biologistHandbookDataSet.phylum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.phylum". При необходимости она может быть перемещена или удалена.
            this.phylumTableAdapter.Fill(this.biologistHandbookDataSet.phylum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.kingdom". При необходимости она может быть перемещена или удалена.
            this.kingdomTableAdapter.Fill(this.biologistHandbookDataSet.kingdom);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to confirm the changes?",
                "Data chanding", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                kingdomBindingSource.EndEdit();
                kingdomTableAdapter.Update(biologistHandbookDataSet);
                phylumTableAdapter.Update(biologistHandbookDataSet);
            }
        }
    }
}
