using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataConn.InsertData();

        List<int> values = DataConn.GetData();
        for (int i=0; i<values.Count; ++i)
            Response.Write(values[i]);
    }
}