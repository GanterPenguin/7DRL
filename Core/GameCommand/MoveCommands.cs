namespace _7DRL.Core.GameCommand
{
  public class MoveCommands(IEntity entity)
  {
    public IEntity Entity { get; private set; } = entity;
    public MoveUp MoveUp = new(entity);
    public MoveDown MoveDown = new(entity);
    public MoveLeft MoveLeft = new(entity);
    public MoveRight MoveRight = new(entity);
  }

  public class MoveUp(IEntity entity) : IGameCommand
  {
    IEntity Entity { get; set; } = entity;

    public void Execute()
    {
      Entity.Move(0, -1);
    }
  }

  public class MoveDown(IEntity entity) : IGameCommand
  {
    IEntity Entity { get; set; } = entity;

    public void Execute()
    {
      Entity.Move(0, 1);
    }
  }

  public class MoveLeft(IEntity entity) : IGameCommand
  {
    IEntity Entity { get; set; } = entity;

    public void Execute()
    {
      Entity.Move(-1, 0);
    }
  }

  public class MoveRight(IEntity entity) : IGameCommand
  {
    IEntity Entity { get; set; } = entity;

    public void Execute()
    {
      Entity.Move(1, 0);
    }
  }
}
