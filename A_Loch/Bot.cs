using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    public class Bot : Spieler
    {
        public Bot() : base()
            { 

            }
        private void karteaussuchen(Ausgespielt a)
        {
            for (int i = 0; i < hand.count();i++)
            {
                if(hand.getKarte(i).getWert() == a.getKarte)
                {

                }
            }
        }
    }
}
