namespace InstrumentIndustry.Models;

public class Report
{
    public int Id { get; set; }
    public Result Result { get; set; }
    public byte[] FileData { get; set; }
}