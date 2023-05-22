namespace TilfeldigeFirkanterOppgave;

public class VirtualScreenRow
{
    public VirtualScreenCell[] _cells;

    public VirtualScreenRow(int screenWidth)
    {
        _cells = new VirtualScreenCell[screenWidth];
        for (int i = 0; i <_cells.Length; i++)
        {
            _cells[i] = new VirtualScreenCell();
        }
    }

    public void AddBoxTopRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddUpperLeftCorner();
        for (int i = boxX+1; i < boxX+boxWidth-1; i++)
        {
            _cells[i].AddHorizontal();
        }
        _cells[boxX+boxWidth-1].AddUpperRightCorner();
 
    }

    public void AddBoxBottomRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddLowerLeftCorner();
        for (int i = boxX+1; i < boxX+boxWidth-1; i++)
        {
            _cells[i].AddHorizontal();
        }
        _cells[boxX+boxWidth-1].AddLowerRightCorner();
    }

    public void AddBoxMiddleRow(int boxX, int boxWidth)
    {
        _cells[boxX].AddVertical();

        _cells[boxX+boxWidth-1].AddVertical();
    }

    public void Show()
    {
        foreach (var cell in _cells)
        {
            var tegn = cell.GetCharacter();
            Console.Write(tegn);
        }

        Console.WriteLine();
    }
}