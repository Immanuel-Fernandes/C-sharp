using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1
{
    public partial class ip1dv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdCal_Click(object sender, EventArgs e)
        {
            int num, org, rev = 0, digit, sum = 0;
            num = System.Convert.ToInt32(Txt_1.Text);
            org = num;
            while (num > 0)
            {
                digit = num % 10;
                rev = rev * 10 + digit;
                sum = sum + digit;
                num = num / 10;
            }
            Lbl_Reverse.Text = System.Convert.ToString(rev);
            Lbl_Sum.Text = System.Convert.ToString(sum); 
        }
    }
}