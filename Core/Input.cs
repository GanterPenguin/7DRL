using Raylib_cs;

namespace _7DRL.Core
{
  public class Input
  {

    public static bool IsKeyUp { get => Raylib.IsKeyPressedRepeat(KeyboardKey.W) || Raylib.IsKeyPressed(KeyboardKey.W); }
    public static bool IsKeyDown { get => Raylib.IsKeyPressedRepeat(KeyboardKey.S) || Raylib.IsKeyPressed(KeyboardKey.S); }
    public static bool IsKeyLeft { get => Raylib.IsKeyPressedRepeat(KeyboardKey.A) || Raylib.IsKeyPressed(KeyboardKey.A); }
    public static bool IsKeyRight { get => Raylib.IsKeyPressedRepeat(KeyboardKey.D) || Raylib.IsKeyPressed(KeyboardKey.D); }
  }
}
