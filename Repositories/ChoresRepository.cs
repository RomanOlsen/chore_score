
using System.Reflection.Metadata;

namespace chore_score.Repositories;
public class ChoresRepository
{

  public ChoresRepository(IDbConnection db)
  {
    _db = db;
  }
  private readonly IDbConnection _db; // idbconnection is related to Dapper
  internal List<Chore> GetChores()
  {
    string sqlCommand = "SELECT * FROM chores;";
    List<Chore> theChores = _db.Query<Chore>(sqlCommand).ToList();
    return theChores;
  }

  internal Chore AddChore(Chore choreData)
  {
    string sqlCommand = @"
      insert into chores 
      (name, description, `isComplete`, `isFun`)
      VALUES
      (@Name, @Description, @isComplete, @isFun);

      SELECT * FROM chores WHERE id = LAST_INSERT_ID();";

    Chore addedChore = _db.Query<Chore>(sqlCommand, choreData).SingleOrDefault();
    return addedChore;
  }

  internal Chore CompleteChore(int choreId)
  {

    // Chore foundChore = this.GetChoreById(choreId);

    string sqlCommand = @"
  UPDATE chores
  SET isComplete = true
  WHERE id = @choreId;
  
  SELECT * FROM chores WHERE id = @choreId;";

    Chore completedChore = _db.Query<Chore>(sqlCommand, new { choreId = choreId }).SingleOrDefault();
    return completedChore;

  }


  // public Chore GetChoreById(int choreId)
  // {
  //   string sql = "SELECT * FROM chores WHERE id = @choreId;"; //
  //   Chore chore = _db.Query<Chore>(sql, new { Id = choreId }).SingleOrDefault();
  //   return chore;
  // }
}