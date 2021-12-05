using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiTask_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fZad1 z1 = new fZad1();
            z1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fZad2 z2 = new fZad2();
            z2.ShowDialog();
        }
    }
}
