using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class Kitsune : Yokai
    {
        public Kitsune(int x, int y, Joueur player) : base(x, y, player)
        {
            IsMovingDiagUpRight = true;
            IsMovingDiagDownLeft = true;
            IsMovingDiagUpLeft = true;
            IsMovingDiagDownRight = true;
        }



    }
}
