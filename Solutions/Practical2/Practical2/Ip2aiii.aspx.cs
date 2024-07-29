using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical2
{
    public partial class Ip2aiii : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdCheck_Click(object sender, EventArgs e)
        {
            BusLogic obj = new BusLogic();

            double a = int.Parse(Txt_a.Text);
            double b = int.Parse(Txt_b.Text);
            double c = int.Parse(Txt_c.Text); 

            obj.SetCoefficients(a, b, c);
            Lbl_roots.Text = obj.Display();
        }


    }

    class BusLogic
    {
        private double a, b, c;
        private string roots;

        public void SetCoefficients(double CoA, double CoB, double CoC)
        {
            a = CoA;
            b = CoB;
            c = CoC;
            CalculateRoots();
        }

        private void CalculateRoots()
        {
            double d = b * b - 4 * a * c;
            double sqrtD = System.Math.Sqrt(System.Math.Abs(d));

            if (d > 0)
            {
                double r1 = (-b + sqrtD) / (2 * a);
                double r2 = (-b - sqrtD) / (2 * a);
                roots = "Roots are real and different:\nRoot1 = " + r1 + "\nRoot2 = " + r2;
            }
            else if (d == 0)
            {
                double r = -b / (2 * a);
                roots = "Roots are real and same:\nRoot = " + r;
            }
            else
            {
                double realPart = -b / (2 * a);
                double imagPart = sqrtD / (2 * a);
                roots = "Roots are complex:\nRoot1 = " + realPart + " + " + imagPart + "i\nRoot2 = " + realPart + " - " + imagPart + "i";
            }
        }

        public string Display()
        {
            return roots;
        }
    }
}