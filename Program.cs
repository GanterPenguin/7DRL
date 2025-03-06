using Raylib_cs;
using _7DRL.ScreenUtilities;

namespace _7DRL
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "7DRL");
      Raylib.SetTargetFPS(60);
      Raylib.SetExitKey(KeyboardKey.Null);

      ScreenManager screenManager = new();

      while (!Raylib.WindowShouldClose())
      {
        if (Raylib.IsKeyPressed(KeyboardKey.Escape)) screenManager.ToggleMenu();
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.Black);

        screenManager.Render();

        Raylib.EndDrawing();
      }
      Raylib.CloseWindow();
    }
  }
}
