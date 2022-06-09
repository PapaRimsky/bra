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
    public partial class Poj : Form
    {
        Addautors f1;

        public Poj()
        {
            InitializeComponent();
        }

        public Poj(Addautors f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Addpoj add = new Addpoj(this);
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                f1.comboBox1.Items.Add(row.Cells[0].Value.ToString());
            }
            Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

      

    }
}
