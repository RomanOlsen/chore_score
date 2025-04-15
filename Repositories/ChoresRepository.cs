namespace chore_score.Repositories;
public class ChoresRepository
{

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db;
  internal List<Chore> GetChores()
  {
    string sqlCommand = "SELECT * FROM chores;";
    List<Chore> theChores = _db.Query<Chore>(sqlCommand).ToList();
    return theChores;
  }
}