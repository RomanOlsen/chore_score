namespace chore_score.Models;
public class Chore
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Description { get; set; }
  public bool isComplete { get; set; }
  public bool isFun { get; set; }

  // ADD ADDITIONAL PROPERTIES HERE SO THAT THEY MATCH THE COLUMNS ON YOUR MYSQL TABLE
}