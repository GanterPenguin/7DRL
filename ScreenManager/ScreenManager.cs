using _7DRL.ScreenUtilities.Screens;

namespace _7DRL.ScreenUtilities
{
  public class ScreenManager(GameScreen screen = GameScreen.Gameplay)
  {
    private GameScreenTypeEnum CurrentScreen { get; set; } = screen;
    private readonly GameplayScreen GameplayScreen = new();
    private readonly MenuScreen MenuScreen = new();

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
