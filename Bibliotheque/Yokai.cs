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
        protected Joueur _player;
        private bool isMovingLeft;
        private bool isMovingRight;
        private bool isMovingUp;
        private bool isMovingDown;
        private bool isMovingDiagUpRight;
        private bool isMovingDiagDownRight;
        private bool isMovingDiagUpLeft;
        private bool isMovingDiagDownLeft;

        public Joueur Player
        {
            get
            {
                return _player;
            }
            set
            {
                _player = value;
            }
        }

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }
        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        public bool IsMovingLeft { get => isMovingLeft; set => isMovingLeft = value; }
        public bool IsMovingRight { get => isMovingRight; set => isMovingRight = value; }
        public bool IsMovingUp { get => isMovingUp; set => isMovingUp = value; }
        public bool IsMovingDown { get => isMovingDown; set => isMovingDown = value; }
        public bool IsMovingDiagUpRight { get => isMovingDiagUpRight; set => isMovingDiagUpRight = value; }
        public bool IsMovingDiagDownRight { get => isMovingDiagDownRight; set => isMovingDiagDownRight = value; }
        public bool IsMovingDiagUpLeft { get => isMovingDiagUpLeft; set => isMovingDiagUpLeft = value; }
        public bool IsMovingDiagDownLeft { get => isMovingDiagDownLeft; set => isMovingDiagDownLeft = value; }

        public Yokai(int x, int y, Joueur player)
        {
            _x = x;
            _y = y;
            _player = player;
            IsMovingLeft = false;   //De base, on interdit tous les déplacements, on les autorisera en fonction des Yokais dans 
            IsMovingRight = false; //les constructeurs des classes filles.
            IsMovingUp = false;
            IsMovingDown = false;
            IsMovingDiagUpRight = false;
            IsMovingDiagDownRight = false;
            IsMovingDiagUpLeft = false;
            IsMovingDiagDownLeft = false;
        }
    }
}
