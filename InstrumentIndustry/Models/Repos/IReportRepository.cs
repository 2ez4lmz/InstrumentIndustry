using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface IReportRepository
{
    ObservableCollection<Report> Get();
    Report GetById(int id);
    void Create(Report report);
    void Update(Report report);
    void Delete(int id);
}