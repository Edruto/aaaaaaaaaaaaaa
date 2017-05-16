using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class Yokai
    {
        protected int _x;
        protected int _y;
        protected bool _player;

        public Yokai(int x, int y, Joueur player)
        {
            _x = x;
            _y = y;
            _player = player;
        }
    }
}
