using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Person
/// </summary>
public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public decimal MobileNumber { get; set; }
    public DateTime DOB { get; set; }
    public Person()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}