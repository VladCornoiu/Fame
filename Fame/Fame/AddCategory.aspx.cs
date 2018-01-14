using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCategory : System.Web.UI.Page
{
    private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    private SqlCommand command;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CreateCategoryButton_Click(object sender, EventArgs e)
    {
        string title = CategoryTitle.Text;
        string description = CategoryContent.InnerText;

        try
        {
            string sqlQuery = "INSERT INTO Category (Title, Description) VALUES (@title, @content)";
            connection.Open();

            command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("title", title);
            command.Parameters.AddWithValue("content", description);
            command.ExecuteNonQuery();

            ReturnMessage.Text = "New category inserted";
        }
        catch (SqlException ex)
        {
            ReturnMessage.Text = "Database error: " + ex.Message;
        }
        finally
        {
            connection.Close();
        }
    }
}