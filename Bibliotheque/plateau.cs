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
        private Joueur joueur1;
        private Joueur joueur2;
        const int _x = 3;
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

        public Joueur Joueur1 { get => joueur1; set => joueur1 = value; }
        public Joueur Joueur2 { get => joueur2; set => joueur2 = value; }

        public Plateau()
        {

            Joueur1 = new Joueur(1);
            Joueur2 = new Joueur(2);
            _plat = new Yokai[_x, _y];
            _plat[1, 1] = new Kodama(1, 1, Joueur1);
            _plat[0, 0] = new Kitsune(0, 0, Joueur1);
            _plat[2, 0] = new Tanuki(2, 0, Joueur1);
            _plat[1, 0] = new Koropokkuru(1, 0, Joueur1);

            _plat[1, 2] = new Kodama(1, 2, Joueur2); //TO DO : Les mettres à la bonne place (ils écrasent les autres valeurs ici)
            _plat[0, 3] = new Kitsune(0, 3, Joueur2);
            _plat[2, 3] = new Tanuki(2, 3, Joueur2);
            _plat[1, 3] = new Koropokkuru(1, 3, Joueur2);
        }

        #region Test
        public int VerifDeplacement(int destx, int desty, Joueur play) //Test si une piece se truove là où le yokai veut se déplacer
        {
            if (destx < _x && destx >= 0 && desty >= 0 && desty < _y) //Si on est pas hors du plateau
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

        public bool VerifVictoire(Joueur player)
        {
            bool contains = false;
            bool isKoroInAdvLine = true;
            int PlayerKoroX = 0;
            int PlayerKoroY = 0;
            foreach(Yokai item in _plat)  //On cherche le Koropukkuru du joueur
            {
                if(item.Player == player && item is Koropokkuru)
                {
                    PlayerKoroX = item.x;
                    PlayerKoroY = item.y;
                }
            }
            foreach (Yokai item in player.Reserve) //On cherche si le joueur à capturé le Koropokkuru adverse
            {
                if (item is Koropokkuru)
                    contains = true;
            }

            if (PlayerKoroY == 3) // Si le koropokkuru est dans la ligne de promotion ennemie
            {
                if(PlayerKoroX < 1) //Pour ne pas sortir de l'index vu qu'on va tester tous les côtés du koropukkuru
                {
                    if ( (_plat[PlayerKoroX + 1, PlayerKoroY].IsMovingLeft && _plat[PlayerKoroX + 1, PlayerKoroY].Player != player) || (_plat[PlayerKoroX, PlayerKoroY - 1].IsMovingUp && _plat[PlayerKoroX, PlayerKoroY - 1].Player != player) || (_plat[PlayerKoroX + 1, PlayerKoroY - 1].IsMovingDiagUpLeft && _plat[PlayerKoroX + 1, PlayerKoroY-1].Player != player) ) //Si un Yokai ennemi peux capturer le koropokkuru
                        isKoroInAdvLine = false; //Alors le joueur ne peux pas gagner ainsi
                }
                if(PlayerKoroX == 1)
                {
                    if ((_plat[PlayerKoroX + 1, PlayerKoroY].IsMovingLeft && _plat[PlayerKoroX + 1, PlayerKoroY].Player != player) || (_plat[PlayerKoroX, PlayerKoroY - 1].IsMovingUp && _plat[PlayerKoroX, PlayerKoroY - 1].Player != player) || (_plat[PlayerKoroX + 1, PlayerKoroY - 1].IsMovingDiagUpLeft && _plat[PlayerKoroX + 1, PlayerKoroY - 1].Player != player) || _plat[PlayerKoroX - 1, PlayerKoroY].IsMovingRight && _plat[PlayerKoroX - 1, PlayerKoroY].Player != player || _plat[PlayerKoroX - 1, PlayerKoroY - 1].IsMovingDiagUpRight && _plat[PlayerKoroX - 1, PlayerKoroY - 1].Player != player) //Si un Yokai ennemi peux capturer le koropokkuru
                        isKoroInAdvLine = false; //Alors le joueur ne peux pas gagner ainsi
                }
                if(PlayerKoroY > 1)
                {
                    if ((_plat[PlayerKoroX - 1, PlayerKoroY].IsMovingRight && _plat[PlayerKoroX - 1, PlayerKoroY].Player != player) || (_plat[PlayerKoroX, PlayerKoroY - 1].IsMovingUp && _plat[PlayerKoroX, PlayerKoroY - 1].Player != player) || (_plat[PlayerKoroX - 1, PlayerKoroY - 1].IsMovingDiagUpRight && _plat[PlayerKoroX - 1, PlayerKoroY - 1].Player != player)) //Si un Yokai ennemi peux capturer le koropokkuru
                        isKoroInAdvLine = false; //Alors le joueur ne peux pas gagner ainsi
                }
            }
            else
                isKoroInAdvLine = true;
            

            if (contains == true || isKoroInAdvLine == true)
                return true;
            else
                return false;
        }
        #endregion

        #region Deplacements

        public void Deplacement_haut(Yokai yok) //Deplacement haut d'un Yokai
        {
            if (yok.IsMovingUp)
            {
                int res;

                res = VerifDeplacement(yok.x, yok.y +1, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.y++;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x, yok.y + 1].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x, yok.y + 1]);
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
                int res;

                res = VerifDeplacement(yok.x, yok.y - 1, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.y++;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x, yok.y - 1].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x, yok.y - 1]);
                    Plat[yok.x, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.y--;
                }
            }

        }

        public void Deplacement_gauche(Yokai yok) //Deplacement gauche d'un Yokai
        {
            if (yok.IsMovingLeft)
            {
                int res;

                res = VerifDeplacement(yok.x - 1, yok.y, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x - 1, yok.y] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x - 1, yok.y].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x - 1, yok.y]);
                    Plat[yok.x - 1, yok.y] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                }
            }

        }

        public void Deplacement_droite(Yokai yok) //Deplacement droite d'un Yokai
        {
            if (yok.IsMovingRight)
            {
                int res;

                res = VerifDeplacement(yok.x +1, yok.y, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x + 1, yok.y] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x + 1, yok.y].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x + 1, yok.y]);
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
                int res;

                res = VerifDeplacement(yok.x+1, yok.y+1, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x + 1, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                    yok.y++;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x + 1, yok.y + 1].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x + 1, yok.y + 1]);
                    Plat[yok.x + 1, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x = yok.x + 1;
                    yok.y = yok.y + 1 ;
                }
            }

        }

        public void Deplacement_diagonale_basse_droite(Yokai yok) //Deplacement diagonale basse droite d'un Yokai
        {
            if (yok.IsMovingDiagDownRight)
            {
                int res;

                res = VerifDeplacement(yok.x + 1, yok.y - 1, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x + 1, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x++;
                    yok.y--;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x + 1, yok.y - 1].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x + 1, yok.y - 1]);
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
                int res;

                res = VerifDeplacement(yok.x - 1 , yok.y + 1, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x - 1, yok.y + 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                    yok.y++;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x - 1, yok.y + 1].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x - 1, yok.y + 1]);
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
                int res;

                res = VerifDeplacement(yok.x-1, yok.y-1, yok.Player);
                if (res == 0) //Si la case est vide
                {
                    Plat[yok.x - 1, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                    yok.y--;
                }

                if (res == 2) //Si un ennemi est disposé dessus
                {
                    Plat[yok.x - 1, yok.y - 1].Player = yok.Player;
                    yok.Player.Reserve.Add(Plat[yok.x - 1, yok.y - 1]);
                    Plat[yok.x - 1, yok.y - 1] = yok;
                    Plat[yok.x, yok.y] = null;
                    yok.x--;
                    yok.y--;
                }

            }
        }
        #endregion

        #region parachutage

        public void Parachutage(int destx, int desty, Yokai yok)
        {
            int res;
            res = VerifDeplacement(destx, desty, yok.Player);

            if (res == 0)
            {
                if (yok.Player.Reserve.Contains(yok))
                {
                    Plat[destx, desty] = yok;
                    yok.Player.Reserve.Remove(yok);
                }
            }
        }

        #endregion
    }
}
