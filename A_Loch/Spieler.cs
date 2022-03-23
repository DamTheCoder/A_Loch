using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{


    public class Spieler
    {
        public string Name;
        public Hand spielerliste;

        //Konschtruktor
        public Spieler(string n, Hand s1)
        {
            Name = n; 
            spielerliste = s1; //Übernimmt Liste von Karten vom Spielleiter
        }

       

       
        /// <summary>
        /// Überprüft ob der spieler Karten gewählt hat und spielt diese ggf. aus ansonsten wird dem Spielleiter gesagt das nix gespielt wird
        /// </summary>
        /// <param name="gewählteKarte"> Liste an ausgewählten Karten </param>
        /// <returns> bool wert ob Karten gespielt werden </returns>
        public bool weiterspielen(List<Karte> gewählteKarte)
        {
            if (gewählteKarte.Count == 0) // Überprüfe ob Karten zum ausspielen gewählt wurden
            {
                return false; 
            }
            gespielteKartenlöschen(); //Lösche die Ausgewählten karten aus der Hand
            return true; 
        }



        

        
        /// <summary>
        /// Überprüft ob noch Karten da sind
        /// </summary>
        /// <param name="spielerliste"> liste der Karten </param>
        /// <returns> bool wert ob Karten vorhanden sind </returns>
        public bool hastdunochkarten(List<Hand> spielerliste)
        {
            if (spielerliste.Count > 0) //Überprüfe ob ich Karten auf der Hand hab
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
        public virtual bool isKarosieben()
        {
            return false;
        }
        
        /// <summary>
        /// Merkt sich die Platzierung      
        /// </summary>
        /// <returns> Die Platzierung als int </returns>
        public int status()
        {
            return 0;
        }

        public string kommentar()
        {
            return "Der geht auf die Dörfer";
        }

        public string ergebnis()
        {
            return "Du hast verkackt";
        }
    }


}

