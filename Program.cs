using System;

using Raylib_cs;

namespace _7DRL
{
  class Program
  {
    static void Main(string[] args)
    {
      Raylib.InitWindow(800, 600, "7DRL");

      Raylib.SetTargetFPS(60);

      while (!Raylib.WindowShouldClose())
      {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("Hello C# Window", 10, 10, 20, Color.Red);

        Raylib.EndDrawing();
      }
      Raylib.CloseWindow();
    }
  }
}
