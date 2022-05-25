using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    public class Bot : Spieler
    {
        public List<Karte> gewählteKarte;
        public Bot(string n, Hand h1) : base(n,h1)
            {

            }
        private void karteaussuchen(Ausgespielt a)
        {
            for (int i = hand.count(); i < 0;i--)
            {
                if(hand.getKarte(i).getWert() > a.getKarte(1).getWert())
                {
                    Kartenwert j = hand.getKarte(i).getWert();
                    if(hand.CountWert(j) >= a.CountWert(j))
                    {
                        if (gewählteKarte.Count() < a.count())
                        {
                            gewählteKarte.Add(hand.getKarte(i));
                        }
                        else
                        {
                            this.weiterspielen();
                        }
                    }
                }
            }
            this.weiterspielen();
        }
    }
}
