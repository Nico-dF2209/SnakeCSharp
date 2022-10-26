using SnakeCSharp.Classes;

namespace SnakeCSharp
{
    internal class Snake : VarSup
    {

        Snake()
        {
            X[0] = 5;
            Y[0] = 5;
            Console.CursorVisible = false;
            collectibleX = random.Next(2, Width - 2);
            collectibleY = random.Next(2, Height - 2);
        }

        static void Main(string[] args)
        {
            Snake snake = new Snake();
            Board board = new Board();
            Touches touche = new Touches();

            while (true)
            {
            board.AfficherTableau();
            touche.EntreeTouches();
            snake.AfficherPerso(2,2);
            snake.Mechanique();
            }
            Console.ReadKey();
        }
    }
}