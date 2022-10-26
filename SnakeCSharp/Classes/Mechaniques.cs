using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCSharp.Classes
{
    public class Mechaniques : VarSup
    {
        public Mechaniques() { }

        ConsoleKeyInfo toucheInfo = new ConsoleKeyInfo();
        
        // on verifie si la touche entree correspond bien a une touche existante
        public void EntreeTouches()
        {
            if (Console.KeyAvailable)
            {
                toucheInfo = Console.ReadKey(true);
                touche = toucheInfo.KeyChar;
            }
        }
        public void Mechanique()
        {
            // positionne aletoirement un collectible sur le tableau
            if (X[0] == collectibleX)
            {
                if (Y[0] == collectibleY)
                {
                    segments++;
                    collectibleX = random.Next(2, Width - 2);
                    collectibleY = random.Next(2, Height - 2);
                }
            }
            // permet que les segments du snake se suivent
            for (int i = segments; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }
            // gere les deplacment sur le tableau du serpent 
            switch (touche)
            {
                case 'z':
                    Y[0]--;
                    break;
                case 's':
                    Y[0]++;
                    break;
                case 'd':
                    X[0]--;
                    break;
                case 'q':
                    X[0]++;
                    break;
            }
            // affiche le serpent et les collectibles
            for(int i = 0; i<=(segments-1); i++)
            {
                AfficherPerso(X[i], Y[i]);
                AfficherPerso(collectibleX, collectibleY);
            }
            //permet de gerer le nombre de refresh par seconde
            Thread.Sleep(100);
        }
    }
}
