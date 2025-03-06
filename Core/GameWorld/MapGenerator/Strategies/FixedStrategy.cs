using _7DRL.Core.GameWorld.MapGenerator.Patterns;

namespace _7DRL.Core.GameWorld.MapGenerator.Strategies
{
  public class FixedStrategy : IGeneratorStrategy
  {
    public Map Generate(int width = 100, int height = 100)
    {
      Map baseMap = new(width, height);
      Map room = Room.Create(5, 5);
      Map bigRoom = Room.Create(10, 10);
      baseMap.Insert(60, 60, room);
      baseMap.Insert(40, 40, bigRoom);

      return baseMap;
    }
  }
}
