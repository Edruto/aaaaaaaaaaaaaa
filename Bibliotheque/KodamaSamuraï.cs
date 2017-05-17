using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    public class KodamaSamuraï : Kodama
    {
        public KodamaSamuraï(int x, int y, Joueur player) : base(x, y, player)
        {
            IsMovingLeft = true;
            IsMovingRight = true;
            IsMovingUp = true;
            IsMovingDown = true;
            IsMovingDiagUpRight = true;
            IsMovingDiagUpLeft = true;

        }
    }
}
