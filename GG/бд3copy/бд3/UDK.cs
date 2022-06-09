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
    public partial class UDK : Form
    {
        Addworks f1;
        public UDK()
        {
            InitializeComponent();
            
        }
        public UDK(Addworks f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Addudk newform = new Addudk(this);
            newform.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.comboBox2.Items.Clear();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                f1.comboBox2.Items.Add(row.Cells[0].Value.ToString());
            }
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           Close();
        }

    }
}
