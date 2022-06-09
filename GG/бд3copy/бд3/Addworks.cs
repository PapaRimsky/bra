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
    public partial class Addworks : Form
    {
        Scienceworks f1;
        UDK f2;

        public Addworks(Scienceworks f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }
        public Addworks(UDK f2)
        {
            this.f2 = f2;
            InitializeComponent();
        }

        private void добавитьИздательствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Publisher newform = new Publisher(this);
            newform.Show();
        }

        private void добавитьUDKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //UDK f = new UDK();
            //f.Owner = this;
            //f.Show();
            //UDK newform = new UDK(this);
            //newform.Show();
            UDK newform = new UDK(this);
            newform.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            f1.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, dateTimePicker1.Text, textBox3.Text, comboBox2.Text, comboBox1.Text);
            Close();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
