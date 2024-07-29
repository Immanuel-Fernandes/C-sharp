using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1
{
    public partial class ip1dii : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdPrime_Click(object sender, EventArgs e)
        {
            int num, i;
            bool isPrime = true;

            num = System.Convert.ToInt32(Txt_1.Text);

            for (i = 2; i <= num / 2; i++)
            {
                if ((num % i) == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Lbl_1.Text = num + " is a prime number";
            }
            else
            {
                Lbl_1.Text = num + " is not a prime number";
            }
        }

    }
}