using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeCSharp.Classes
{
    class Touches : VarSup
    {
        public Touches(){}

        ConsoleKeyInfo toucheInfo= new ConsoleKeyInfo();
        char touche = 'z'; 
        public void EntreeTouches()
        {
            if (Console.KeyAvailable)
            {
                toucheInfo=Console.ReadKey(true);
                touche =toucheInfo.KeyChar;
            }
        }
    }
}
 