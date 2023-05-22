namespace TilfeldigeFirkanterOppgave;

public class VirtualScreenCell
{
    private bool Up { get; set; }
    private bool Down { get; set; }
    private bool Left { get; set; }
    private bool Right { get; set; }
    private char opp = '╹';
    private char ned = '╻';
    private char venstre = '╺';
    private char høyre = '╸';

    public char GetCharacter()
    {
        var x = ' ';
        if (!Up && !Down && !Left && !Right) return ' ';
        if (!Up && !Down && !Left && Right) return '╺';
        if (!Up && !Down && Left && !Right) return '╸';
        if (!Up && !Down && Left && Right) return '─';
        if (!Up && Down && !Left && !Right) return '╻';
        if (!Up && Down && !Left && Right) return '┌';
        if (!Up && Down && Left && !Right) return '┐';
        if (!Up && Down && Left && Right) return '┬';
        if (Up && !Down && !Left && !Right) return '╹';
        if (Up && !Down && !Left && Right) return '└';
        if (Up && !Down && Left && !Right) return '┘';
        if (Up && !Down && Left && Right) return '┴';
        if (Up && Down && !Left && !Right) return '│';
        if (Up && Down && !Left && Right) return '├';
        if (Up && Down && Left && !Right) return '┤';
        if (Up && Down && Left && Right) return '┼';
        return x;
    }

    public void AddHorizontal()
    {
        Left = Right = true;
    }


    public void AddVertical()
    {
        Up = true;
        Down = true;
    }

    public void AddLowerLeftCorner()
    {
        Up = true;
        Right = true;
    }

    public void AddUpperLeftCorner()
    {
        Down = true;
        Right = true;
    }

    public void AddUpperRightCorner()
    {
        Down = true;
        Left = true;
    }

    public void AddLowerRightCorner()
    {
        Up = true;
        Left = true;
    }
}