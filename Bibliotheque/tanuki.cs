using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class Tanuki : Yokai
    {
        public Tanuki(int x, int y, Joueur player) : base(x, y, player)
        {
            IsMovingDown = true;
            IsMovingLeft = true;
            IsMovingRight = true;
            IsMovingUp = true;
        }

    }
}
