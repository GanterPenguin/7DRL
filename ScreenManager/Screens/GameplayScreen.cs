using Raylib_cs;
using _7DRL.Core;
using _7DRL.Core.GameWorld;
using _7DRL.Core.GameWorld.MapGenerator.Strategies;
using _7DRL.Core.GameWorld.MapGenerator;

namespace _7DRL.ScreenUtilities.Screens
{

  public class GameplayScreen : IScreenManagerScreen
  {
    readonly int ScreenWidth = 800;
    readonly int ScreenHeight = 600;
    readonly int TileSize = 20;

    readonly Map WorldMap;
    readonly Player Player;
    readonly MapGenerator MapGenerator;

    public GameplayScreen()
    {

      FixedStrategy strategy = new();
      MapGenerator = new MapGenerator(strategy);
      WorldMap = MapGenerator.Generate(100, 100);
      Player = new(50, 50);
    }
    public void DrawMap()
    {
      int tilesCountY = ScreenHeight / TileSize;
      int tilesCountX = ScreenWidth / TileSize;
      int startX = Player.Position.X - (tilesCountX / 2);
      int startY = Player.Position.Y - (tilesCountY / 2);
      for (int x = 0; x < ScreenWidth; x += TileSize)
      {
        for (int y = 0; y < ScreenHeight; y += TileSize)
        {
          Cell cell = WorldMap.GetCellFromScreenSpace(startX, startY, x, y, TileSize);
          Raylib.DrawText(cell.ToString(), x, y, TileSize, Color.White);
        }
      }
    }

    public void Render()
    {
      Player.HandleInput(WorldMap);
      DrawMap();
      Player.Draw(TileSize);
    }
  }
}
