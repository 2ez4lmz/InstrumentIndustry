using System;

namespace InstrumentIndustry.Models;

public class Employee
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    public Position Position { get; set; }
    public Department Department { get; set; }
    public int Salary { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime EmployeeDate { get; set; }
    public DateTime LastAttestationDate { get; set; }
}