namespace _7DRL.Core.GameWorld.MapGenerator
{
  public class MapGenerator(IGeneratorStrategy strategy)
  {
    private IGeneratorStrategy GeneratorStrategy { get; set; } = strategy;

    public void SetStrategy(IGeneratorStrategy strategy)
    {
      GeneratorStrategy = strategy;
    }

    public Map Generate(int width, int height)
    {
      return GeneratorStrategy.Generate(width, height);
    }
  }
  public interface IGeneratorStrategy
  {
    public Map Generate(int width, int height);
  }
}
