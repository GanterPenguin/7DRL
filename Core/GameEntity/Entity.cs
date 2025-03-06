using Raylib_cs;

namespace _7DRL.Core.GameEntity
{
  public abstract class BaseEntity : IEntity
  {
    public abstract Position Position { get; set; }
    public abstract string Char { get; set; }
    public abstract Color ForegroundColor { get; set; }
    public abstract Color BackgroundColor { get; set; }
    public void Move(int dx, int dy)
    {
      Position.X += dx;
      Position.Y += dy;
    }
    public abstract void Draw(int tileSize);
  }
  public interface IEntity
  {
    public Position Position { get; set; }
    public string Char { get; set; }

    public Color ForegroundColor { get; set; }
    public Color BackgroundColor { get; set; }

    public abstract void Move(int dx, int dy);

    public abstract void Draw(int tileSize);
  }
}
