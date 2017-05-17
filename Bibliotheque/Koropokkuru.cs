using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotheque
{
    class Koropokkuru : Yokai
    {
        public Koropokkuru(int x, int y, Joueur player) : base(x, y, player)
        {
            IsMovingLeft = true;   //De base, on interdit tous les déplacements, on les autorisera en fonction des Yokais dans 
            IsMovingRight = true; //les constructeurs des classes filles.
            IsMovingUp = true;
            IsMovingDown = true;
            IsMovingDiagUpRight = true;
            IsMovingDiagDownRight = true;
            IsMovingDiagUpLeft = true;
            IsMovingDiagDownLeft = true;
        }
    }
}
