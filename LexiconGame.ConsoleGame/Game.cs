using System.Data;

internal class Game
{
    private Map map = null!;
    private Hero hero = null!;

    internal void Run()
    {
        Initialize();
        Play();
    }

    private void Play()
    {
        map.GetType();
        throw new NotImplementedException();
    }

    private void Initialize()
    {
        //ToDo: Read from config
        map = new Map(width: 10, height: 10);
        hero = new Hero();
    }
}