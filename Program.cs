using System.Linq.Expressions;

Board board = new Board();
Player player1 = new Player(CellType.X);
Player player2 = new Player(CellType.O);

while (true)
{

    board.DisplayBoard();
    player1.TakeTurn(board);
    board.DisplayBoard();
    player2.TakeTurn(board);
}





public class Player 
{ 
    public CellType XorO { get;}

    public Player (CellType xorO)
    {
        XorO = xorO;
    }

    public void TakeTurn(Board board)
    {
        bool cellAvailable = false;

        
        while (!cellAvailable)
        {
            Console.Write($"Choose a square player '{XorO}'");
            string turn = Console.ReadLine();

            switch (turn)
            {
                case "1":
                    cellAvailable = board.SetCell(0, 0, XorO);
                    continue;
                case "2":
                    cellAvailable = board.SetCell(0, 1, XorO);
                    continue;
                case "3":
                    cellAvailable = board.SetCell(0, 2, XorO);
                    continue;
                case "4":
                    cellAvailable = board.SetCell(1, 0, XorO);
                    continue;
                case "5":
                    cellAvailable = board.SetCell(1, 1, XorO);
                    continue;
                case "6":
                    cellAvailable = board.SetCell(1, 2, XorO);
                    continue;
                case "7":
                    cellAvailable = board.SetCell(2, 0, XorO);
                    continue;
                case "8":
                    cellAvailable = board.SetCell(2, 1, XorO);
                    continue;
                case "9":
                    cellAvailable = board.SetCell(2, 2, XorO);
                    continue;
                default:
                    Console.WriteLine("Please enter a valid square number.");
                    cellAvailable = false;
                    continue;
            }

        }

        
    }       
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