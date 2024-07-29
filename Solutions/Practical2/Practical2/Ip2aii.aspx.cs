using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical2
{
    public partial class Ip2aii : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private float rupees;

        protected void CmdCal_Click(object sender, EventArgs e)
        {
            float rupees = float.Parse(Txt_1.Text);
            Lbl_3.Text = rupees + " Rs. is equal to " + Paise(rupees) + " Paise";
        }

        private float Paise(float r)
        {
            float paise = r * 100;
            return paise;
        }
    }
}