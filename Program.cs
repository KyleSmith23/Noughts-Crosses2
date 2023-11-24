using System.Linq.Expressions;

Board board = new Board();

board.SetCell(1, 2, CellType.X);
board.DisplayBoard();



// Player - if player X/O setcell = x or o != empty
public class Player 
{ 



}


public class Board
{
    private readonly CellType[,] _cells = new CellType[3, 3];

    public CellType GetCell(int row, int col)
    {   
        
        return _cells[row, col];
    }

    public bool SetCell(int row, int col, CellType celltype)
    {
        if (_cells[row, col] != CellType.Empty ) 
            return false;

        _cells[row, col] = celltype; 
            return true;
    }

    public void DisplayBoard()
    {   
        
        Console.WriteLine($" {ToChar(GetCell(0, 0))} | {ToChar(GetCell(0, 1))} | {ToChar(GetCell(0, 2))} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {ToChar(GetCell(1, 0))} | {ToChar(GetCell(1, 1))} | {ToChar(GetCell(1, 2))} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {ToChar(GetCell(2, 0))} | {ToChar(GetCell(2, 1))} | {ToChar(GetCell(2, 2))} ");

    }

    private char ToChar(CellType celltype) => celltype switch
    {
        CellType.Empty => ' ',
        CellType.X => 'X',
        CellType.O => 'O',
        _          => '?',
    };

}

public enum CellType
{
    Empty,
    X,
    O
}