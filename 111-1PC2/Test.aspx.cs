using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1PC2
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
            {
            int i_in = 66377;
                double d_Ou = 0;
                double d_i_In = i_in;
                d_Ou = (9.0 / 5.0) * d_i_In + 32.0;
                Response.Write(d_Ou);
            }
    }
}