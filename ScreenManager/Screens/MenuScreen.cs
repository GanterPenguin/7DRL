using Raylib_cs;

namespace _7DRL.ScreenUtilities.Screens
{
  public class MenuScreen() : IScreenManagerScreen
  {
    public void Render()
    {
      Raylib.DrawText("MENU SCREEN", 20, 20, 40, Color.LightGray);
    }
  }
}
