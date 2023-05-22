using System.Threading.Channels;
using TilfeldigeFirkanterOppgave;
public class Program
{
    public static int _width = 40;
    public static int _height = 20;

    static void Main(string[] args)
    {
        while (true)
        {
            var boxes = CreateBoxes();
            Show(boxes);
            Thread.Sleep(100);
            MoveNow(boxes);
            Console.WriteLine("(press enter for new. ctrl+c=exit)");
            Console.ReadLine();
        }
        
    }

    private static void MoveNow(Box[] boxes)
    {
        var loop = true;
        while (loop)
        {
            foreach (var box in boxes)
            {
                box.Move();
                if (box.X + 1 + box.Width >= _width && box.Y + 1 + box.Height >= _height) box.looping = false;
            }

            loop = boxes[0].looping || boxes[1].looping || boxes[2].looping;
            Show(boxes);
            Thread.Sleep(100);
        }
    }


    private static Box[] CreateBoxes()
    {
        var random = new Random();
        var boxes = new Box[3];
        for (var i = 0; i < boxes.Length; i++)
        {
            boxes[i] = new Box(random, _width, _height);
        }
        return boxes;
    }

    private static void Show(Box[] boxes)
    {
        var screen = new VirtualScreen(_width,_height);
        foreach (var box in boxes)
        {
            screen.Add(box);
        }
        Console.Clear();
        screen.Show();
    }
}