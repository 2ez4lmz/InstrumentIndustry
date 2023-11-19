namespace InstrumentIndustry.Models;

public class CommissionMember
{
    public int Id { get; set; }
    public Employee Employee { get; set; }
    public Commission Commission { get; set; }
    public CommissionRole CommissionRole { get; set; }
}