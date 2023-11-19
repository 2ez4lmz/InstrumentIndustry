using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface IDepartmentRepository
{
    ObservableCollection<Department> Get();
    Department GetById(int id);
    void Create(Department department);
    void Update(Department department);
    void Delete(int id);
}