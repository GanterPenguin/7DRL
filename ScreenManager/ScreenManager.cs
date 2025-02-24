using _7DRL.ScreenUtilities.Screens;

namespace _7DRL.ScreenUtilities
{
  public class ScreenManager(GameScreenTypeEnum screen = GameScreenTypeEnum.Gameplay)
  {
    private GameScreenTypeEnum CurrentScreen { get; set; } = screen;
    private readonly GameplayScreen GameplayScreen = new();
    private readonly MenuScreen MenuScreen = new();

    public void ToggleMenu()
    {
      CurrentScreen = CurrentScreen == GameScreenTypeEnum.Gameplay ? GameScreenTypeEnum.Menu : GameScreenTypeEnum.Gameplay;
    }

    public void Render()
    {
      switch (CurrentScreen)
      {
        case GameScreenTypeEnum.Gameplay:
          {
            GameplayScreen.Render();
          }
          break;
        case GameScreenTypeEnum.Menu:
          {
            MenuScreen.Render();
          }
          break;
      }
    }
  }

  public enum GameScreenTypeEnum
  {
    Gameplay = 0,
    Menu
  }

  public interface IScreenManagerScreen
  {
    void Render();
  }

}
