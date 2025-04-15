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

}