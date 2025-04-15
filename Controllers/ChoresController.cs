[ApiController]
[Route("chores")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;
  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> GetChores()
  {
    try
    {
      List<Chore> choresGotten = _choresService.GetChores();
      return Ok(choresGotten);

    }
    catch (Exception)
    {
      return BadRequest();
    }
  }

  [HttpPost]
  public ActionResult<Chore> AddChore([FromBody] Chore choreData)
  {
    try
    {
      Chore addedChore = _choresService.AddChore(choreData);
      return Ok(addedChore);
    }
    catch (Exception)
    {
      return BadRequest();
    }
  }
  [HttpPut("{choreId}")]
  public ActionResult<Chore> CompleteChore(int choreId)
  {
    try
    {
      Chore completedChore = _choresService.CompleteChore(choreId);
      return completedChore;
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpDelete("{choreId}")]
  public ActionResult<string> DeleteChore(int choreId){ // use string since we only need to return a message
    try
    {
      _choresService.DeleteChore(choreId);
      return Ok($"Chore {choreId} was deleted");
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

}