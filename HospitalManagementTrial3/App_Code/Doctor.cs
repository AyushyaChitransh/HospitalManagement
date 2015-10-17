using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Doctor
/// </summary>
public class Doctor: Person
{
    public DateTime Slot1Start { get; set; }
    public DateTime Slot2Start { get; set; }
    public int Capacity1 { get; set; }
    public int Capacity2 { get; set; }
    public Doctor()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}