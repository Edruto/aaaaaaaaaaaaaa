using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Plateau
    {
        private int[,] _cases;
        const int _x = 3;
        const int _y = 5;


        public Plateau()
        {
            _cases = new int[_x,_y];
        }

        public bool HorsPlateau(int x,int y)
        {
            if (x <= _x && x >= 0 && y >= 0 && y <= _y)
                return false;
            else
                return true;
        }


    }
}
