using SnakeCSharp.Classes;

namespace SnakeCSharp
{
    internal class Snake
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Board board = new Board();
            Touches touche = new Touches();
            board.PrintBoard();
            touche.EntreeTouches();
            Console.ReadKey();
        }
    }
}