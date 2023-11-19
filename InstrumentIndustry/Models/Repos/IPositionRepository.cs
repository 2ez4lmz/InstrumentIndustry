using System.Collections.ObjectModel;

namespace InstrumentIndustry.Models.Repos;

public interface IPositionRepository
{
    ObservableCollection<Position> Get();
    Position GetById(int id);
    void Create(Position position);
    void Update(Position position);
    void Delete(int id);
}