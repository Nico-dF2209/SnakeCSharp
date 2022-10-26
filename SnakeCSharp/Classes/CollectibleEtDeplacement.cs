using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCSharp.Classes
{
    public class CollectibleEtDeplacement : VarSup
    {
        public CollectibleEtDeplacement() { }
       
        Random random = new Random();
        public void AfficherPoint(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("0");
        }

        public void Mechaniques()
        {
            if (X[0] == collectibleX)
            {
                if (Y[0] == collectibeY)
                {
                    segments++;
                    collectibleX = random.Next(2, Width - 2);
                }
            }
        }
    }
}
