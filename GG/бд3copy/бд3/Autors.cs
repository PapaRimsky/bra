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
    public partial class Autors : Form
    { 
        public Autors(Scienceworks scienceworks)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Addautors newform = new Addautors(this);
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delete = dataGridView1.SelectedCells[0].RowIndex;
            dataGridView1.Rows.RemoveAt(delete);
        }
    }
}
