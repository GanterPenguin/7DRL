namespace _7DRL.Core
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
      set { Cells[x, y] = value; }
    }

    public Cell GetCellFromScreenSpace(int startX, int startY, int screenX, int screenY, int tileSize)
    {
      int mapX = screenX == 0 ? startX : startX + screenX / tileSize;
      int mapY = screenY == 0 ? startY : startY + screenY / tileSize;
      return this[mapX, mapY];
    }
  }
}
