

namespace chore_score.Services;
public class ChoresService
{

  public ChoresService(ChoresRepository repository)
  {
    _repository = repository;
  }
  private readonly ChoresRepository _repository;
  internal List<Chore> GetChores()
  {
    List<Chore> choresGotten = _repository.GetChores();
    return choresGotten;
  }

  internal Chore AddChore(Chore data)
  {
    Chore addedChore = _repository.AddChore(data);
    return addedChore;
  }

  internal Chore CompleteChore()
  {
    throw new NotImplementedException();
  }
}