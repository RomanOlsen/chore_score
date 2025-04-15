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
  public ActionResult<Chore> AddChore([FromBody] Chore choreData){
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
  public ActionResult<Chore> CompleteChore(int choreId){
    try
    {
      Chore completedChore = _choresService.CompleteChore();
      return completedChore;
    }
    catch (Exception)
    {
      return BadRequest();
    }
  }

}