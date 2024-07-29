using System;
/*
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 * 
 */

namespace Practical2
{
    public partial class Ip2aiv : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdCal_Click(object sender, EventArgs e)
        {
            float n = float.Parse(Txt_1.Text);
            
            Lbl_3.Text = Cel(n) + " degree Celsius ";
        }

        private float Cel(float far)
        {
            float cel = (far - 32) / 1.8f;
            return cel;
        }
    }
}