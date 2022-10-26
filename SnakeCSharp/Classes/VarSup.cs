using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCSharp.Classes
{
    public abstract class VarSup
    {

        public int Height = 20;
        public int Width = 30;

        public int[] X = new int[50];
        public int[] Y = new int[50];

        public char touche = 'z';

        public int collectibleX, collectibleY;

        public int segments = 3;

        public Random random = new Random();

        public void AfficherPerso(int x, int y) { }
        public void Mechanique() { }
        public void AfficherTableau() { }
        public void EntreeTouches() { }


    }
    
        
}
