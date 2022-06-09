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
    public partial class Addautors : Form
    {
        Autors f1;
        
        public Addautors(Autors f1)
        {
            this.f1 = f1;
            InitializeComponent();
        } 

        private void Savebutton_Click(object sender, EventArgs e)
        {
            f1.dataGridView1.Rows.Add(textBox1.Text, dateTimePicker1.Text, comboBox1.Text, comboBox2.Text);
            Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void добавитьМестоРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poj add = new Poj(this);
           add.Show();
        }

        private void добавитьНаучнуюСтепеньToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Degree add = new Degree(this);
            add.Show();
        }
    }
}
