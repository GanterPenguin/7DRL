using _7DRL.Core.GameCommand;
using Raylib_cs;

namespace _7DRL.Core
{
  public class Player : IEntity
  {
    public int X { get; set; }
    public int Y { get; set; }
    public string Char { get; set; } = "@";
    public Color ForegroundColor { get; set; } = Color.White;
    public Color BackgroundColor { get; set; } = Color.White;
    public MoveCommands MoveCommands { get; set; }
    public Map Map { get; set; }

    public Player(int x, int y, Map map)
    {
      X = x;
      Y = y;
      MoveCommands = new MoveCommands(this);
      Map = map;
    }

    public void Draw(int tileSize)
    {
      Raylib.DrawText("@", 400, 300, tileSize, ForegroundColor);
    }

    public void HandleInput()
    {
      if (Input.IsKeyUp) MoveCommands.MoveUp.Execute();
      if (Input.IsKeyDown) MoveCommands.MoveDown.Execute();
      if (Input.IsKeyLeft) MoveCommands.MoveLeft.Execute();
      if (Input.IsKeyRight) MoveCommands.MoveRight.Execute();
    }
  }
}
