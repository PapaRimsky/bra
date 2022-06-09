using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace бд3
{
    public partial class Scienceworks : Form
    {
        public Scienceworks()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            Addworks newform = new Addworks(this);
            newform.Show();
        }

        private void Autorsbutton_Click(object sender, EventArgs e)
        {
            Autors newform = new Autors(this);
            newform.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int delete = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delete);
        }

        private void добавитьОбразованиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degree newform = new Degree();
            newform.Show();
        }

        private void добавитьИздательствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publisher newform = new Publisher();
            newform.Show();
        }

        private void добавитьUDKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UDK f = new UDK();
            //    f.Owner = this;
            //    f.ShowDialog();
            Addworks newform1 = new Addworks(this);
            newform1.Show();
            UDK newform = new UDK(newform1);
            newform.Show();
        }

        private void добавитьМестоРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poj newform = new Poj();
            newform.Show();
        }
    }
}
