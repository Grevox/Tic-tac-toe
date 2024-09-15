using Tic_tac_toe;

public class TicTacToe
{
    
    public static void Main(String[] args)
    {
        Console.WriteLine("TicTacToe by Grevox");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        Console.WriteLine("                   ");
        callmeplease();



    }

    public const string player = "Player1 always starts first";
    public static void callmeplease()
    {
        Console.CursorSize = 50;
        Console.CursorVisible = false;
        Console.SetWindowSize(500, 500);
        Console.Title = "Tic tac toe [TyToM]";
        Console.WriteLine("Hello, this, is tic tac toe in the terminal!!! ");
        Console.WriteLine("[Press enter to continue]");
        Console.ReadLine();
        Console.WriteLine(player);
        Console.ReadLine();

        var P1 = new Pl1();


    }
    }



