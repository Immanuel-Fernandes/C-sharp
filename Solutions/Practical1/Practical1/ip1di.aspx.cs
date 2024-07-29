using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1
{
    public partial class ip1di : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdFibonacci_Click(object sender, EventArgs e)
        {
            int a = 0, b = 1, c, n, i;
            n = System.Convert.ToInt32(Txt_1.Text);
            i = 3;
            string fibonacciSequence = a + "\t" + b;

            for (i = 3; i <= n; i++)
            {
                c = a + b;
                fibonacciSequence += "\t" + c;
                a = b;
                b = c;
            }

            Txt_2.Text = fibonacciSequence;
        }
    }
}