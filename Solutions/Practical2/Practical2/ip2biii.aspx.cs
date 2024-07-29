using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical2
{
    public partial class ip2biii : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdCalculate_Click(object sender, EventArgs e)
        {
            int a = int.Parse(Txt_1.Text);
            Sum S1 = new Sum(a);
            int S = S1.Cal();

            int b = int.Parse(Txt_2.Text);
            int c = int.Parse(Txt_3.Text);
            Sum S2 = new Sum(b,c);
            int t = S2.Cal();

            Lbl_3.Text = "Sum of " + a + " + 10 = " + S + ".";
            Lbl_4.Text = "Sum of " + b + " + " + c + " = " + t + ".";
        }

        // Constructor overloading:
        public class Sum
        {
            private int a,b;
            public int c;

            public Sum(int num)
            {
                this.a = num;
                this.b = 10;
            }

            public Sum(int num1, int num2)
            {
                this.a = num1;
                this.b = num2;
            }

            public int Cal()
            {
                c= a + b;
                return c;
            }
        }

    }
}