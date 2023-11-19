using System;

namespace InstrumentIndustry.Models;

public class Result
{
    public int Id { get; set; }
    public Employee Employee { get; set; }
    public Commission Commission { get; set; }
    public bool AResult { get; set; }
    public bool Decision { get; set; }
    public DateTime Date { get; set; }
}