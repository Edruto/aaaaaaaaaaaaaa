using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       
namespace Bibliotheque
{
    public class Joueur
    {

        private Yokai[] _reserve;
        private int _nbYokaiReserve;
        private int _ID;
        public int ID
        {
            get { return _ID; }
        }
        public Yokai[] Reserve
        {
            get { return _reserve; }
            set { _reserve = value; }
        }

        public Joueur(int id)
        {
            _reserve = new Yokai[3];
            _ID = id;
            int couleur;
            int[] tabcouleur = new int[] { 0x01B0F0, 0x000000, 0xB9121B, 0xFF358B, 0xFCFAE1, 0xAEEE00, 0xC617E1 }; //nb de couleurs disponible pour l'interface du joueur

        }

        public void reserveAdd(Yokai yok) //Ajout d'un yokai dans la reserve du joueur
        {
            if (_nbYokaiReserve <= 3)
            {
                _reserve[_nbYokaiReserve] = yok;
                _nbYokaiReserve++;
            }
        }

    }
}
