using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical2
{
    public partial class ip2ai : System.Web.UI.Page
    {
        private int f;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdFact_Click(object sender, EventArgs e)
        { 
            int n = int.Parse(Txt_1.Text);  
            Fact(n);
            Lbl_3.Text = "Factorial of " + n + " is: " + Fact(n); ;
        }

        private int Fact(int n)
        {
            f = 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }            
            return f;
        }
    }
}