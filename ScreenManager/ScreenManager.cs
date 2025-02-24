using _7DRL.ScreenUtilities.Screens;

namespace _7DRL.ScreenUtilities
{
  public class ScreenManager(GameScreen screen = GameScreen.Gameplay)
  {
    public GameScreen CurrentScreen { get; set; } = screen;
    public IScreenManagerScreen GameplayScreen = new GameplayScreen();
    public IScreenManagerScreen MenuScreen = new MenuScreen();

    public void ToggleMenu()
    {
      CurrentScreen = CurrentScreen == GameScreen.Gameplay ? GameScreen.Menu : GameScreen.Gameplay;
    }

    public void Render()
    {
      switch (CurrentScreen)
      {
        case GameScreen.Gameplay:
          {
            GameplayScreen.Render();
          }
          break;
        case GameScreen.Menu:
          {
            MenuScreen.Render();
          }
          break;
      }
    }
  }

  public enum GameScreen
  {
    Gameplay = 0,
    Menu
  }

  public interface IScreenManagerScreen
  {
    void Render();
  }

}
