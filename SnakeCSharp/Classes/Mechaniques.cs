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

        public void Mechanique()
        {
            if (X[0] == collectibleX)
            {
                if (Y[0] == collectibleY)
                {
                    segments++;
                    collectibleX = random.Next(2, Width - 2);
                    collectibleY = random.Next(2, Height - 2);
                }
            }
            for (int i = segments; i > 1; i--)
            {
                X[i - 1] = X[i - 2];
                Y[i - 1] = Y[i - 2];
            }
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
            for(int i = 0; i<=(segments-1); i++)
            {
                AfficherPerso(X[i], Y[i]);
                AfficherPerso(collectibleX, collectibleY);
            }
            Thread.Sleep(100);
        }
    }
}
