namespace _7DRL.Core
{
  public class Cell(int x, int y, bool isTransparent = true, bool isWalkable = true, bool isEmpty = false)
  {
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public bool IsTransparent { get; set; } = isTransparent;
    public bool IsWalkable { get; set; } = isWalkable;

    public bool IsEmpty { get; set; } = isEmpty;

    public override string ToString()
    {
      if (IsEmpty) return " ";
      if (IsWalkable)
      {
        if (IsTransparent) return ".";
        return "s";
      }

      if (IsTransparent) return "o";
      return "#";
    }
  }
}
