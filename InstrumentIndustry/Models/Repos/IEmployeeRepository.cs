using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface IEmployeeRepository
{
    ObservableCollection<Employee> Get();
    Employee GetById(int id);
    void Create(Employee employee);
    void Update(Employee employee);
    void Delete(int id);
}