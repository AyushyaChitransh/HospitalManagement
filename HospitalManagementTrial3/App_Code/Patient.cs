using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for Patient
/// </summary>
public class Patient :Person
{
    public string Disease { get; set; }
    public Patient()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int NewRegistration(Patient obj)
    {
        string cs = WebConfigurationManager.ConnectionStrings[0].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        return 1;
    }
}