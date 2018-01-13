using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    private SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
    private SqlCommand command;

    private string sqlQuery;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        string username = CreateUserWizard1.UserName;
        Roles.AddUserToRole(username, "Member");

        sqlQuery = "Insert into Users (Username) values ('" + username + "')";
        command = new SqlCommand(sqlQuery, connection);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    protected void CreateUserWizard1_ContinueButtonClick(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }

    protected void CreateUserWizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        TextBox t = CreateUserWizard1.FindControl("TBFirstName") as TextBox;
        if (t != null)
        {
            Profile.FirstName = t.Text;
        }

        t = CreateUserWizard1.FindControl("TBLastName") as TextBox;
        if (t != null)
        {
            Profile.LastName = t.Text;
        }

        t = CreateUserWizard1.FindControl("TBBirthday") as TextBox;
        if (t != null)
        {
            Profile.Birthday = DateTime.Parse(t.Text);
        }

        Profile.JoinDate = DateTime.Now;

        sqlQuery = "Update Users SET FirstName = '" + Profile.FirstName + "', LastName = '" + Profile.LastName + "', DOB = '" + Profile.Birthday + "' where Username = '" + System.Web.HttpContext.Current.User.Identity.Name + "';";
        command = new SqlCommand(sqlQuery, connection);
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }
}