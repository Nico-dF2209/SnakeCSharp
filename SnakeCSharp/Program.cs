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
            Board board = new Board();
            Perso perso = new Perso();
            Mechaniques mecha = new Mechaniques();

            while (true)
            {
            board.AfficherTableau();
            mecha.EntreeTouches();
            perso.AfficherPerso(3,3);
            mecha.Mechanique();
            }
            Console.ReadKey();
        }
    }
}