using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    private SqlCommand command;
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void CreateNewCategory_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/AddCategory.aspx");
    }
}