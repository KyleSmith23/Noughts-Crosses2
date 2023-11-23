public class Board
{
    private CellType[,] _cells = new CellType[3, 3];

    public CellType GetCell(int row, int col)
    { 
        return _cells[row, col];
    }

    public bool SetCell(int row, int col, CellType celltype)
    {
        if (_cells[row, col] != CellType.Empty ) return false;

        _cells[row, col] = celltype; return true;
    }
}

public enum CellType
{
    Empty,
    X,
    O
}