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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.phylum". При необходимости она может быть перемещена или удалена.
            this.phylumTableAdapter.Fill(this.biologistHandbookDataSet.phylum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.kingdom". При необходимости она может быть перемещена или удалена.
            this.kingdomTableAdapter.Fill(this.biologistHandbookDataSet.kingdom);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "biologistHandbookDataSet.domains". При необходимости она может быть перемещена или удалена.
            this.domainsTableAdapter.Fill(this.biologistHandbookDataSet.domains);

        }
    }
}
