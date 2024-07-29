using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical1
{
    public partial class ip1diii : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CmdVowel_Click(object sender, EventArgs e)
        {
            string letter = Txt_1.Text;

            char ch = letter[0];

            ch = char.ToLower(ch);
            
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                {
                    Lbl_1.Text = "It is a Vowel";
                }
            else
                {
                    Lbl_1.Text = "It is not a Vowel";
                } 
        }
    }
}