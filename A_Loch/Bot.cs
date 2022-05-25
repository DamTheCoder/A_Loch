using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{                                   
    /// <summary>
    /// spielt Karten ohne menschliche Hilfe
    /// @author Louis
    /// </summary>
    public class Bot : Spieler  
    {
        public List<Karte> gewaehlteKarten;
        public Bot(string n, Hand h1) : base(n,h1)
            {

            }
        private void karteaussuchen(Ausgespielt a)
        {
            for (int i = hand.count(); i < 0;i--)   //Bot geht die Liste von unten nach oben durch
            {
                if(hand.getKarte(i).getWert() > a.getKarte(1).getWert())    // Bot sucht nach Karten mit höherem Wert als die zuletzt gespielten
                {
                    Kartenwert j = hand.getKarte(i).getWert();
                    if(hand.CountWert(j) >= a.count())  //Bot überprüft ob er genug Karten des gleichen Wertes hat, welche er ausspielen kann
                    {
                        if (gewaehlteKarten.Count() < a.count())  //solange die Liste "gewählteKarten" weniger Karten als der Ablagestapel hat, wird eine weitere Karte des Wertes hinzugefügt
                        {
                            gewaehlteKarten.Add(hand.getKarte(i));
                        }
                        else
                        {
                            this.weiterspielen();
                            return;
                        }
                    }
                }
            }
            this.weiterspielen();
            return;
        }
    }
}
