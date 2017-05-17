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
        private Joueur Joueur1;
        private Joueur Joueur2;
        const int _x = 2;
        const int _y = 4;

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

            Joueur1 = new Joueur(1);
            Joueur2 = new Joueur(2);
            _plat = new Yokai[_x, _y];
            _plat[1, 1] = new Kodama(1, 1, Joueur1);
            _plat[0, 0] = new Kitsune(0, 0, Joueur1);
            _plat[0, 2] = new Tanuki(0, 2, Joueur1);
            _plat[0, 1] = new Koropokkuru(0, 1, Joueur1);

            _plat[1, 1] = new Kodama(1, 1, Joueur2);
            _plat[0, 0] = new Kitsune(0, 0, Joueur2);
            _plat[0, 2] = new Tanuki(0, 2, Joueur2);
            _plat[0, 1] = new Koropokkuru(0, 1, Joueur2);
        }

        public int VerifDeplacement(int destx, int desty, Joueur play) //Test si une piece se truove là où le yokai veut se déplacer
        {
            if (destx <= _x && destx >= 0 && desty >= 0 && desty <= _y) //Si on est pas hors du plateau
            {
                if (Plat[destx, desty] != null) //Si la case n'est pas vide
                {
                    if (Plat[destx, desty].Player.ID == play.ID) //Si on veut aller sur une case où il y a un Yokai allié
                    {
                        return 1; //CODE 1 : IMPOSSIBLE
                    }
                    if (Plat[destx, desty].Player.ID != play.ID) //Si on veut aller sur une case où il y a un Yokai ennemi
                    {
                        return 2;
                    }
                }
                else //Si on est sur une case vide
                    return 0; //CODE 0 : On peux s'y déplacer
            }
            else
                return 1;
            return 1;
        }

        public void Deplacement_haut(Yokai yok) //Deplacement haut d'un Yokai
        {
            if (yok.IsMovingUp)
            {
                if (VerifDeplacement(yok.x, yok.y + 1, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.y++;
                }

                if (VerifDeplacement(yok.x, yok.y + 1, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x, yok.y + 1]);
                    Plat[yok.x, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.y++;
                }
            }

        }

        public void Deplacement_bas(Yokai yok) //Deplacement bas d'un Yokai
        {
            if (yok.IsMovingDown)
            {
                if (VerifDeplacement(yok.x, yok.y - 1, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.y++;
                }

                if (VerifDeplacement(yok.x, yok.y - 1, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x, yok.y - 1]);
                    Plat[yok.x, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.y--;
                }
            }

        }

        public void Deplacement_gauche(Yokai yok) //Deplacement gauche d'un Yokai
        {
            if (yok.IsMovingDown)
            {
                if (VerifDeplacement(yok.x - 1, yok.y, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x - 1, yok.y] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                }

                if (VerifDeplacement(yok.x - 1, yok.y, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x - 1, yok.y]);
                    Plat[yok.x - 1, yok.y] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                }
            }

        }

        public void Deplacement_droite(Yokai yok) //Deplacement droite d'un Yokai
        {
            if (yok.IsMovingDown)
            {
                if (VerifDeplacement(yok.x + 1, yok.y, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x + 1, yok.y] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                }

                if (VerifDeplacement(yok.x + 1, yok.y, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x + 1, yok.y]);
                    Plat[yok.x + 1, yok.y] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                }
            }

        }
        public void Deplacement_diagonale_haute_droite(Yokai yok) //Deplacement diagnoale haute droite d'un Yokai
        {
            if (yok.IsMovingDiagUpRight)
            {
                if (VerifDeplacement(yok.x + 1, yok.y + 1, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x + 1, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                    yok.y++;
                }

                if (VerifDeplacement(yok.x + 1, yok.y + 1, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x + 1, yok.y + 1]);
                    Plat[yok.x + 1, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                    yok.y++;
                }
            }

        }

        public void Deplacement_diagonale_basse_droite(Yokai yok) //Deplacement diagonale basse droite d'un Yokai
        {
            if (yok.IsMovingDiagDownRight)
            {
                if (VerifDeplacement(yok.x + 1, yok.y - 1, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x + 1, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                    yok.y--;
                }

                if (VerifDeplacement(yok.x + 1, yok.y - 1, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x + 1, yok.y - 1]);
                    Plat[yok.x + 1, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                    yok.y--;
                }
            }

        }

        public void Deplacement_diagonale_haute_gauche(Yokai yok) //Deplacement diagnoale haute gauche d'un Yokai
        {
            if (yok.IsMovingDiagUpLeft)
            {
                if (VerifDeplacement(yok.x - 1, yok.y + 1, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x - 1, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                    yok.y++;
                }

                if (VerifDeplacement(yok.x - 1, yok.y + 1, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x - 1, yok.y + 1]);
                    Plat[yok.x - 1, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                    yok.y++;
                }
            }

        }

        public void Deplacement_diagonale_basse_gauche(Yokai yok) //Deplacement diagonale basse gauche d'un Yokai
        {
            if (yok.IsMovingDiagUpLeft)
            {
                if (VerifDeplacement(yok.x - 1, yok.y - 1, yok.Player) == 0) //Si la case est vide
                {
                    Plat[yok.x - 1, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                    yok.y--;
                }

                if (VerifDeplacement(yok.x - 1, yok.y - 1, yok.Player) == 2) //Si un ennemi est disposé dessus
                {
                    //Condition de victoire avec le korokupuru
                    yok.Player.reserveAdd(Plat[yok.x - 1, yok.y - 1]);
                    Plat[yok.x - 1, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                    yok.y--;
                }
            }


        }
    }
