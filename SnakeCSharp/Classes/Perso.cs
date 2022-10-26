using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCSharp.Classes
{
    public class Perso : VarSup
    {
        public Perso() { }

        //permet d'afficher le perso a l'emplacement choisit
        public void AfficherPerso(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("0");
        }

    }
}
