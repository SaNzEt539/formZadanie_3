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
    public partial class fZad2 : Form
    {
        double a, b, h;
        string str = String.Empty, str2 = String.Empty;
        public fZad2()
        {
            InitializeComponent();
        }
        private void fZad2_Load(object sender, EventArgs e)
        {

        }
        void Func(double a, double b, double h)
        {
            for (double x = a; x <= b; x += h)
            {
                if ((x - 1) < 1)
                {
                    str += "1 ";
                }
                else if ((x - 1) == 1)
                {
                    str += "0 ";
                }
                else
                {
                    str += "-1 ";
                }
            }
        }
        static void Func(double x, out double y)
        {
            if ((x - 1) < 1)
            {
                y = 1;
            }
            else if ((x - 1) == 1)
            {
                y = 0;
            }
            else
            {
                y = -1;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = Double.Parse(tbA.Text);
                b = Double.Parse(tbB.Text);
                h = Double.Parse(tbH.Text);
                Func(a, b, h);
                labRes1.Text = str;
                for (double x = a; x <= b; x += h)
                {
                    double y;
                    Func(x, out y);
                    str2 += y + " ";
                }
                labRes2.Text = str2;
            }
            catch (System.FormatException)
            {
                labRes1.Text = "Введено что-то не то";
            }
            finally
            {
                labRes1.Visible = true;
                labRes2.Visible = true;
            }
        }
    }
}
