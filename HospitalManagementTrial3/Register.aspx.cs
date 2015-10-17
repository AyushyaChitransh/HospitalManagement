using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonRegister_Click(object sender, EventArgs e)
    {
        Patient objPatient = new Patient();
        objPatient.Name = TextBoxName.Text;
        objPatient.Password = TextBoxPassword.Text;
        objPatient.Email = TextBoxEmail.Text;
        objPatient.DOB = DateTime.Parse(TextBoxDOB.Text);
        objPatient.MobileNumber = decimal.Parse(TextBoxMobileNumber.Text);
        if (Patient.NewRegistration(objPatient) != 0)
        {
            Response.Write("<script language='javascript'>alert('Successful!');</script>");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Failed!');</script>");
        }
    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        if (Patient.Exists(TextBoxEmailLogin.Text, TextBoxPasswordLogin.Text))
        {
            Response.Redirect("Dashboard.aspx");
        }
        else
        {
            Response.Write("<script language='javascript'>alert('Login Failed!');</script>");
        }
    }
}