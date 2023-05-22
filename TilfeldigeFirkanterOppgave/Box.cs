namespace TilfeldigeFirkanterOppgave;

public class Box : Program
{
    public int X { get; set; }
    public int Y { get; set; }
    public int StartY => Y;
    public int EndY => Y + Height;
    public int Width { get; }
    public int Height { get; }
    private int _minimumSize = 3;

    public bool looping { get; set; } = true;

    public Box(Random random, int maxX, int maxY)
    {
        Width = random.Next(_minimumSize, maxX);
        Height = random.Next(_minimumSize, maxY);
        X = random.Next(1, (maxX - Width));
        Y = random.Next(1, (maxY - Height));
    }

    public void Move()
    {
        if(X+1+Width < _width) X += 1;
        if(Y+1+Height < _height) Y += 1;
    }
}