using System.Linq.Expressions;

Board board = new Board();
Player player1 = new Player(CellType.X);
Player player2 = new Player(CellType.O);

while (true)
{
    PlayGame(player1, player2, board);
}





void PlayGame(Player p1, Player p2, Board board)
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
            Console.Write($"Choose a square player '{XorO}'");
            string turn = Console.ReadLine();


            switch (turn)
            {
                case "1":
                    board.SetCell(0, 0, XorO);
                    return;
                case "2":
                    board.SetCell(0, 1, XorO);
                    return;
                case "3":
                    board.SetCell(0, 2, XorO);
                    return;
                case "4":
                    board.SetCell(1, 0, XorO);
                    return;
                case "5":
                    board.SetCell(1, 1, XorO);
                    return;
                case "6":
                    board.SetCell(1, 2, XorO);
                    return;
                case "7":
                    board.SetCell(2, 0, XorO);
                    return;
                case "8":
                    board.SetCell(2, 1, XorO);
                    return;
                case "9":
                    board.SetCell(2, 2, XorO);
                    return;
                default:
                    Console.WriteLine("Please enter a valid square number.");
                    return;
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