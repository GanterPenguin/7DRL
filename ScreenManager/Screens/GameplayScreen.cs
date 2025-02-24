using Raylib_cs;

namespace _7DRL.ScreenUtilities.Screens
{
  public class GameplayScreen() : IScreenManagerScreen
  {
    public void Render()
    {
      Raylib.DrawText("GAMEPLAY SCREEN", 20, 20, 40, Color.LightGray);
    }
  }
}
