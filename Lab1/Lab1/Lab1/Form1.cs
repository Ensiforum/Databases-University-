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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet1.phylum". При необходимости она может быть перемещена или удалена.
            this.phylumTableAdapter1.Fill(this.biologistHandbookDataSet1.phylum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet1.kingdom". При необходимости она может быть перемещена или удалена.
            this.kingdomTableAdapter1.Fill(this.biologistHandbookDataSet1.kingdom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet1.domains". При необходимости она может быть перемещена или удалена.
            this.domainsTableAdapter1.Fill(this.biologistHandbookDataSet1.domains);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.phylum". При необходимости она может быть перемещена или удалена.
            this.phylumTableAdapter.Fill(this.biologistHandbookDataSet.phylum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.kingdom". При необходимости она может быть перемещена или удалена.
            this.kingdomTableAdapter.Fill(this.biologistHandbookDataSet.kingdom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.domains". При необходимости она может быть перемещена или удалена.
            this.domainsTableAdapter.Fill(this.biologistHandbookDataSet.domains);

            dataGridView7.AutoGenerateColumns = true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            domainsTableAdapter.Update(biologistHandbookDataSet);
            kingdomTableAdapter.Update(biologistHandbookDataSet);
            phylumTableAdapter.Update(biologistHandbookDataSet);

            domainsTableAdapter1.Update(biologistHandbookDataSet1);
            kingdomTableAdapter1.Update(biologistHandbookDataSet1);
            phylumTableAdapter1.Update(biologistHandbookDataSet1);
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void domainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator7.BindingSource = domainsBindingSource;
            dataGridView7.DataSource = domainsBindingSource;
            label1.Text = "Domains";
        }

        private void kingdomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator7.BindingSource = kingdomBindingSource;
            dataGridView7.DataSource = kingdomBindingSource;
            label1.Text = "Kingdoms";
        }

        private void phylumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator7.BindingSource = phylumBindingSource;
            dataGridView7.DataSource = phylumBindingSource;
            label1.Text = "Phylums";
        }

        private void resettlementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rs = new RSForm();
            rs.ShowDialog();
            domainsTableAdapter.Fill(biologistHandbookDataSet.domains);
            kingdomTableAdapter.Fill(biologistHandbookDataSet.kingdom);
            phylumTableAdapter.Fill(biologistHandbookDataSet.phylum);
        }

    }
}
