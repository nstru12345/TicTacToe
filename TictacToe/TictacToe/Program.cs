using System;
internal class Program
{
    private static void Main(string[] args)
    {
        PlayGame play = new PlayGame();
        Console.WriteLine("Use numbers 1 - 9 to select which box you would like to fill. Player one is x, player 2 is y.");
        Console.WriteLine();
        play.Play();
        Console.ReadLine();

    }
}
                        


public class Player
{
    public int turnTimer = 1;

    public int Turn()
    {
        return turnTimer += 1;
        
    }
    
}

public class RenderBoard
{
    public tictac[,] board = new tictac[3,3];

    public void DrawBoard()
    {
        Console.WriteLine($"{board[0,0]} | {board[0,1]} | {board[0,2]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[1,0]} | {board[1,1]} | {board[1,2]}");
        Console.WriteLine("---------");
        Console.WriteLine($"{board[2,0]} | {board[2,1]} | {board[2,2]}");
    }
}

public class PlayGame
{
    RenderBoard gameBoard = new RenderBoard();
    Player player = new Player();
    tictac current = tictac.b;
    private int topRowValue = 0;
    private int middleRowValue = 0;
    private int bottomRowValue = 0;
    private int columnOne = 0;
    private int columnTwo = 0;
    private int columnThree = 0;

    public tictac SwitchLetter()
    {
        if (player.turnTimer % 2 == 0)
        {
            player.Turn();
            return current = tictac.o;
        }
        else if (player.turnTimer % 2 != 0)
        {
            player.Turn();
            return current = tictac.x;
        }
        return current;
    }
    public void SelectBox()
    {
        int input;
        
        Console.WriteLine("Select your square");
        input = Convert.ToInt32(Console.ReadLine());
        if (input == 1 && gameBoard.board[0,0] == tictac.b)
        {
            gameBoard.board[0, 0] = current;
            addTopValue();
            addColumnOne();
        }
        else if (input == 2 && gameBoard.board[0,1] == tictac.b)
        {
            gameBoard.board[0,1] = current;
            addTopValue();
            addColumnTwo();
        }
        else if (input == 3 && gameBoard.board[0,2] == tictac.b)
        {
            gameBoard.board[0,2] = current;
            addTopValue();
            addColumnThree();
        }
        else if (input == 4 && gameBoard.board[1,0] == tictac.b)
        {
            gameBoard.board[1, 0] = current;
            addMiddleValue();
            addColumnOne();
        }
        else if (input == 5 && gameBoard.board[1,1] == tictac.b)
        {
            gameBoard.board[1,1] = current;
            addMiddleValue();
            addColumnTwo();
        }
        else if (input == 6 && gameBoard.board[1,2] == tictac.b)
        {
            gameBoard.board[1,2] = current;
            addMiddleValue();
            addColumnThree();
        }
        else if (input == 7 && gameBoard.board[2,0] == tictac.b)
        {
            gameBoard.board[2,0] = current;
            addBottomValue();
            addColumnOne();
        }
        else if (input == 8 && gameBoard.board[2,1] == tictac.b)
        {
            gameBoard.board[2,1] = current;
            addBottomValue();
            addColumnTwo();
        }
        else if (input == 9 && gameBoard.board[2,2] == tictac.b)
        {
            gameBoard.board[2, 2] = current;
            addBottomValue();
            addColumnThree();
        }
    }

    private int addTopValue()
    {
        if (current == tictac.x)
            topRowValue += 3;
        else if (current == tictac.o)
            topRowValue += 4;
        return topRowValue;
    }

    private int addMiddleValue()
    {
        if (current == tictac.x)
            middleRowValue += 3;
        else if (current == tictac.o)
            middleRowValue += 4;
        return middleRowValue;
    }

    private int addBottomValue()
    {
        if (current == tictac.x)
            bottomRowValue += 3;
        else if (current == tictac.o)
            bottomRowValue += 4;
        return bottomRowValue;
    }
    private int addColumnOne()
    {
        if (current == tictac.x)
            columnOne += 3;
        else if (current == tictac.o)
            columnOne += 4;
        return columnOne;
    }
    private int addColumnTwo()
    {
        if (current == tictac.x)
            columnTwo += 3;
        else if (current == tictac.o)
            columnTwo += 4;
        return columnTwo;
    }
    private int addColumnThree()
    {
        if (current == tictac.x)
            columnThree += 3;
        else if (current == tictac.o)
            columnThree += 4;
        return columnThree;
    }

    public void Play()
    {
        while (true)
        {
            gameBoard.DrawBoard();
            SwitchLetter();
            SelectBox();
            if (CheckWin() == true)
            {
                gameBoard.DrawBoard();
                break;
            }
        }
    }
    private bool CheckWin()
    {
        if (topRowValue == 9 || middleRowValue == 9 || bottomRowValue == 9)
        {
            Console.WriteLine("x has won!");
            return true;
        }
        else if (topRowValue == 12 || middleRowValue == 12 || bottomRowValue == 12)
        {
            Console.WriteLine("o has won!");
            return true;
        }
        else if (gameBoard.board[0,0] == tictac.x && gameBoard.board[1,1] == tictac.x && gameBoard.board[2,2] == tictac.x)
        {
            Console.WriteLine("x has won!");
            return true;
        }
        else if (gameBoard.board[0,2] == tictac.x && gameBoard.board[0,0] == tictac.x & gameBoard.board[2,2] == tictac.x)
        {
            Console.WriteLine("X has won!");
            return true;
        }
        else if (columnOne == 9 || columnTwo == 9 || columnThree == 9)
        {
            Console.WriteLine("x has won!");
            return true;
        }
        else if (columnOne == 12 || columnTwo == 12 || columnThree == 12)
        {
            Console.WriteLine("o has won!");
            return true;
        }
        else return false;
    }
}

public enum tictac { b, x, o,}

// pick the spot
// replace spot with x or o
//new TicTacToeGame().Run();