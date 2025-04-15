
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

  internal Chore AddChore()
  {
    Chore addedChore = _repository.AddChore();
    return addedChore;
  }
}