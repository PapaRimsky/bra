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
    public partial class Addudk : Form
    {
        UDK f1;
        public Addudk(UDK f1)
        {
            this.f1 = f1;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.dataGridView1.Rows.Add(textBox1.Text);
            Close();
            //f1.save();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
