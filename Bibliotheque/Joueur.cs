using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
       
namespace Bibliotheque
{
    public class Joueur
    {
        
        private Yokai[] reserve;

        public Joueur()
        {
            reserve = new Yokai[3];
            int couleur;
            int[] tabcouleur = new int[] { 0x01B0F0, 0x000000, 0xB9121B, 0xFF358B, 0xFCFAE1, 0xAEEE00, 0xC617E1 };
            
        }
    }
}
