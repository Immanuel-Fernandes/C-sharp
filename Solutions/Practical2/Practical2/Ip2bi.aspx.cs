using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical2
{
    public partial class Ip2bi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdCalculate_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Txt1.Text);
            int S1 = Sum(a);

            int b = int.Parse(Txt2.Text);
            int c = int.Parse(Txt3.Text);

            int t = Sum(b, c);

            Lbl3.Text = "Sum of " + a + " + 10 = " + S1 + ".";
            Lbl4.Text = "Sum of " + b + " + " + c + " = " + t + ".";
        }

        // Function overloading:
        private int Sum(int num)
        {
            return num + 10;
        }

        private int Sum(int a, int b)
        {
            return a + b;
        }
    }
}