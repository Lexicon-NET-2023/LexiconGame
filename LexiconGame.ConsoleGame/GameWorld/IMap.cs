public interface IMap
{
    List<Creature> Creatures { get; }
    int Height { get; }
    int Width { get; }

    Creature? CreatureAt(Cell cell);
    Cell GetCell(int y, int x);
    Cell? GetCell(Position newPosition);
    void Place(Creature creature);
}