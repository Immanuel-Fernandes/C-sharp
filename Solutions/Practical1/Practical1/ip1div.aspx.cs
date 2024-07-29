using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1
{
    public partial class ip1div : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void CmdDisplay_Click(object sender, EventArgs e)
        {            
            int[] numbers = { 1, 2, 3, 4, 5 };

            foreach (int number in numbers)
            {
                lbl_1.Text += number.ToString() + "<br />";
            }
        }
    }
}