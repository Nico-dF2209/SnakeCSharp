using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCSharp.Classes
{
    public abstract class VarSup
    {
        //stock toutes les var utiles pour utiliser l'heritage de la consigne
        public int Height = 20;
        public int Width = 30;

        public int[] X = new int[50];
        public int[] Y = new int[50];

        public int touche = 122;

        public int collectibleX, collectibleY;

        public int segments = 3;

        public Random random = new Random();

        public void AfficherPerso(int x, int y) { }
        
        
        


    }
    
        
}
