namespace _7DRL.Core.GameEntity
{
  public class Position(int x, int y) : IPosition
  {
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
  }

  interface IPosition
  {
    public int X { get; set; }
    public int Y { get; set; }
  }
}
