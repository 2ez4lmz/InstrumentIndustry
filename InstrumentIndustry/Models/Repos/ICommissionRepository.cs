using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface ICommissionRepository
{
    ObservableCollection<Commission> Get();
    Commission GetById(int id);
    void Create(Commission commission);
    void Update(Commission commission);
    void Delete(int id);
}