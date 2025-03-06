using Raylib_cs;

namespace _7DRL.Core.GameWorld
{
  public class Map
  {
    public int Width { get; private set; }
    public int Height { get; private set; }
    private readonly Cell[,] Cells;

    private readonly Cell EmptyCell = new(-1, -1, false, false, true);

    public Map(int width, int height)
    {
      Width = width;
      Height = height;
      Cells = new Cell[Width, Height];

      for (int x = 0; x < Width; x++)
      {
        for (int y = 0; y < Height; y++)
        {
          Cells[x, y] = new Cell(x, y);
        }
      }
    }

    public Cell this[int x, int y]
    {
      get
      {
        if (x >= Width || x < 0 || y >= Height || y < 0)
        {
          return EmptyCell;
        }
        return Cells[x, y];
      }
      set { Cells[x, y] = value; } // TODO: Добавить проверку на границы
    }

    public void Insert(int startX, int startY, Map part)
    {
      if (startX + part.Width > Width || startY + part.Height > Height)
      {
        Raylib.TraceLog(TraceLogLevel.Error, "Map part exceeds base map boundaries");
        return;
      }
      for (int x2 = 0; x2 < part.Width; x2++)
      {
        for (int y2 = 0; y2 < part.Height; y2++)
        {
          int targetX = startX + x2;
          int targetY = startY + y2;
          this[targetX, targetY] = (Cell)part[x2, y2].Clone();
        }
      }
    }

    public Cell GetCellFromScreenSpace(int startX, int startY, int screenX, int screenY, int tileSize)
    {
      int mapX = screenX == 0 ? startX : startX + screenX / tileSize;
      int mapY = screenY == 0 ? startY : startY + screenY / tileSize;
      return this[mapX, mapY];
    }
  }
}
