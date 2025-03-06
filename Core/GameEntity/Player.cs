using _7DRL.Core.GameEntity;
using _7DRL.Core.GameWorld;
using Raylib_cs;

namespace _7DRL.Core
{
  public class Player(int x, int y) : BaseEntity
  {
    public override Position Position { get; set; } = new(x, y);
    public override string Char { get; set; } = "@";
    public override Color ForegroundColor { get; set; } = Color.White;
    public override Color BackgroundColor { get; set; } = Color.White;

    public override void Draw(int tileSize)
    {
      Raylib.DrawText(Char, 400, 300, tileSize, ForegroundColor);
    }

    private bool CanMove(Map? map, int dx, int dy)
    {
      if (map == null) return true;
      return map[Position.X + dx, Position.Y + dy].IsWalkable;
    }

    public void HandleInput(Map? map = null)
    {
      var directions = new (bool inputCheck, int dx, int dy)[]
      {
        (Input.IsKeyUp, 0, -1),
        (Input.IsKeyDown, 0, 1),
        (Input.IsKeyLeft, -1, 0),
        (Input.IsKeyRight, 1, 0)
      };

      foreach (var (inputCheck, dx, dy) in directions)
      {
        if (inputCheck && CanMove(map, dx, dy))
        {
          Move(dx, dy);
        }
      }
    }
  }
}
