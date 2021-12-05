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
    public partial class fZad1 : Form
    {
        static double f(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
        static double d(double a, double b, double c)
        {
            return a + b + c;
        }
        double x1, x2, y1, y2, a, b, c;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                a = Double.Parse(tbA.Text);
                b = Double.Parse(tbB.Text);
                c = Double.Parse(tbC.Text);
                labRes2.Text = "Периметр: " + (a + b + c).ToString();
            }
            catch (System.FormatException)
            {
                labRes2.Text = "Введено что-то не то";
            }
            finally
            {
                labRes2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = Double.Parse(tbX1.Text);
                y1 = Double.Parse(tbY1.Text);
                x2 = Double.Parse(tbX2.Text);
                y2 = Double.Parse(tbY2.Text);
                labRes1.Text = "Длина отрезка: " + Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            }
            catch (System.FormatException)
            {
                labRes1.Text = "Введено что-то не то";
            }
            finally
            {
                labRes1.Visible = true;
            }
        }

        public fZad1()
        {
            InitializeComponent();
        }
    }
}
