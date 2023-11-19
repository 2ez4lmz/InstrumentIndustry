using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface ICommissionMemberRepository
{
    ObservableCollection<CommissionMember> Get();
    CommissionMember GetById(int id);
    void Create(CommissionMember commissionMember);
    void Update(CommissionMember commissionMember);
    void Delete(int id);
}