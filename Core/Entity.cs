using Raylib_cs;

namespace _7DRL.Core
{
  public interface IEntity
  {
    public int X { get; set; }
    public int Y { get; set; }
    public string Char { get; set; }

    public Color ForegroundColor { get; set; }
    public Color BackgroundColor { get; set; }

    public Map Map { get; set; }

    public void Move(int dx, int dy)
    {
      if (CanMoveHere(X + dx, Y + dy))
      {
        X += dx;
        Y += dy;
      }
    }

    public void Draw(int tileSize);

    public bool CanMoveHere(int x, int y)
    {
      return Map[x, y].IsWalkable;
    }
  }
}
