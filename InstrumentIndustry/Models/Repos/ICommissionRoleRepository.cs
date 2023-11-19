using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface ICommissionRoleRepository
{
    ObservableCollection<CommissionRole> Get();
    CommissionRole GetById(int id);
    void Create(CommissionRole commissionRole);
    void Update(CommissionRole commissionRole);
    void Delete(int id);
}