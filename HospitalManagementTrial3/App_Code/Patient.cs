using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.Configuration;

/// <summary>
/// Summary description for Patient
/// </summary>
public class Patient :Person
{
    public string Disease { get; set; }
    public string Prescription { get; set; }
    public Patient(DataRow PatientDetails)
    {
        //
        // TODO: Add constructor logic here
        //
        if (PatientDetails != null)
        {
            ID = int.Parse(PatientDetails["ID"].ToString());
            Name = PatientDetails["Name"].ToString();
            Password = PatientDetails["Password"].ToString();
            MobileNumber = decimal.Parse(PatientDetails["MobileNumber"].ToString());
            Email = PatientDetails["Email"].ToString();
            DOB = DateTime.Parse(PatientDetails["DOB"].ToString()); 
        }
    }
    public Patient()
    {

    }

    /// <summary>
    /// Register a new Patient
    /// </summary>
    /// <param name="NewPatient">Object of patient</param>
    /// <returns>Number of rows affected</returns>
    public static int NewRegistration(Patient NewPatient)
    {
        string cs = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        string qry = "INSERT INTO [tblPatient] ([Name], [Password], [MobileNumber], [Email], [DOB]) VALUES (@Name, @Password, @MobileNumber, @Email, @DOB)";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.Parameters.AddWithValue("@Name", NewPatient.Name);
        cmd.Parameters.AddWithValue("@Password", NewPatient.Password);
        cmd.Parameters.AddWithValue("@MobileNumber", NewPatient.MobileNumber);
        cmd.Parameters.AddWithValue("@Email", NewPatient.Email);
        cmd.Parameters.AddWithValue("@DOB", NewPatient.DOB);
        int effect = 0;
        con.Open();
        effect = cmd.ExecuteNonQuery();
        con.Close();
        return effect;
    }
    /// <summary>
    /// Checks availability of an email in database
    /// </summary>
    /// <param name="email">Email ID of patient</param>
    /// <returns>true if email exists in database else false</returns>
    public static bool Exists(string email)
    {
        string cs = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        string qry = "SELECT * FROM tblPatient WHERE Email=@Email";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.Parameters.AddWithValue("@Email", email);
        bool result;
        con.Open();
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.HasRows)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        con.Close();
        return result;
    }

    public static bool Exists(string email, string password)
    {
        string cs = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection con = new SqlConnection(cs);
        string qry = "SELECT * FROM tblPatient WHERE Email=@Email AND password=@Password";
        SqlCommand cmd = new SqlCommand(qry, con);
        cmd.Parameters.AddWithValue("@Email", email);
        cmd.Parameters.AddWithValue("@Password", password);
        bool result;
        con.Open();
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.HasRows)
        {
            result = true;
        }
        else
        {
            result = false;
        }
        con.Close();
        return result;
    }
}