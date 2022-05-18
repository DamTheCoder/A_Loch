using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{


    public class Spieler
    {
        protected string Name;
        protected Hand hand;
        public List<Karte> gewählteKarte;


        //Konschtruktor
        public Spieler(string n, Hand h1)
        {
            Name = n; 
            hand = h1; 
        }

        public void kartenwaehlen(uint x, uint y)
        {
            //if 
        }

       
        /// <summary>
        /// Überprüft ob der spieler Karten gewählt hat und spielt diese ggf. aus ansonsten wird dem Spielleiter gesagt das nix gespielt wird
        /// </summary>
        /// <param name="gewählteKarte"> Liste an ausgewählten Karten </param>
        /// <returns> bool wert ob Karten gespielt werden </returns>
        public List<Karte> weiterspielen()
        {
            if (gewählteKarte.Count == 0) // Überprüfe ob Karten zum ausspielen gewählt wurden
            {
                return null;
            }
            else if (gewählteKarte.Count != 0)
            {
                    return gewählteKarte;   
            }

            return null;
        }



        

        
        /// <summary>
        /// Überprüft ob noch Karten da sind
        /// </summary>
        /// <param name="spielerliste"> liste der Karten </param>
        /// <returns> bool wert ob Karten vorhanden sind </returns>
        public bool hastdunochkarten()
        {
            if (hand.count() > 0) //Überprüfe ob ich Karten auf der Hand hab
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Überprüft ob Karo 7 in der Hand ist
        /// </summary>
        /// <returns> bool wert ob Karo 7 da is </returns> 
        public bool isKarosieben()
        {
            for (int i = 0; i < hand.count(); i++)
                   
                if (hand.getKarte(i).getFarbe() == Kartenfarbe.Karo && hand.getKarte(i).getWert()== Kartenwert.Sieben)//Überprüft Karten auf Karo 7
                {
                    return true;
                }
            return false;   
        }
        
        /// <summary>
        /// Merkt sich die Platzierung      
        /// </summary>
        /// <returns> Die Platzierung als int </returns>
        

        public string kommentar()
        {
            return "Der geht auf die Dörfer";
        }

        public string ergebnis()
        {
            return "Du hast verkackt";
        }
        //public uint getXwert()
        //{
            //return Karte.X;
        //}
        //public uint getYwert()
        //{
            //return Karte.Y;
        //}

    }


}

