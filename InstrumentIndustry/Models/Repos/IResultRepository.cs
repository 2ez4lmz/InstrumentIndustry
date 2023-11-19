using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface IResultRepository
{
    ObservableCollection<Result> Get();
    Result GetById(int id);
    void Create(Result result);
    void Update(Result result);
    void Delete(int id);
}