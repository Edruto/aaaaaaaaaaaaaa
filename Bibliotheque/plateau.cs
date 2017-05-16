using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Plateau
    {
        private Yokai[,] _plat;
        const int _x = 3;
        const int _y = 5;

        public Yokai[,] Plat
        {
            get
            {
                return _plat;
            }
            set
            {
                _plat = value;
            }

        }

        public Plateau()
        {
            _plat = new Yokai[_x,_y];
            _plat[1,1] = new Kodama(1,1,0);
            _plat[0,0] = new Kitsune(0, 0,0);
            Tanuki Tan = new Tanuki(0, 2);
            Koropokkuru Kor = new Koropokkuru(0, 1);
        }

        public bool HorsPlateau(int x,int y)
        {
            if (x <= _x && x >= 0 && y >= 0 && y <= _y)
                return false;
            else
                return true;
        }

        public bool ValiditeDeplacement(int x, int y) //Test si une piece se truove là où le yokai veut se déplacer
        {
            if (Plat[x,y] != null)
                return false;
            else
                return true;
        }


    }
}
