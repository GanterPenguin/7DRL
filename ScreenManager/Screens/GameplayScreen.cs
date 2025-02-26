using Raylib_cs;
using _7DRL.Core;

namespace _7DRL.ScreenUtilities.Screens
{

  public class GameplayScreen : IScreenManagerScreen
  {
    readonly int ScreenWidth = 800;
    readonly int ScreenHeight = 600;
    readonly int TileSize = 20;

    readonly Map WorldMap = new(20, 20);
    readonly Player Player;

    public GameplayScreen()
    {
      Player = new(10, 10, WorldMap);
    }
    public void DrawMap()
    {
      int tilesCountY = ScreenHeight / TileSize;
      int tilesCountX = ScreenWidth / TileSize;
      int startX = Player.X - (tilesCountX / 2);
      int startY = Player.Y - (tilesCountY / 2);
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
      Player.HandleInput();
      DrawMap();
      Player.Draw(TileSize);
    }
  }
}
