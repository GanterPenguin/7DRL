namespace _7DRL.Core.GameWorld.MapGenerator.Patterns
{
  public static class Room
  {
    public static Map Create(int width, int height)
    {
      Map map = new(width, height);
      for (int x = 0; x < map.Width; x++)
      {
        map[x, 0].IsWalkable = false;
        map[x, map.Height - 1].IsWalkable = false;
        for (int y = 0; y < map.Height; y++)
        {
          if (x == 0 || x == map.Width - 1)
          {
            map[x, y].IsWalkable = false;
          }
        }
      }
      return map;
    }
  }
}
