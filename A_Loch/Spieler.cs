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

        public Spieler(string n, Hand s1)
        {
            Name = n; 
            spielerliste = s1; //Übernimmt Liste von Karten vom Spielleiter
        }

       

        protected void kartensortieren()
        {

        }

        public bool weiterspielen(List<Karte> gewählteKarte)
        {
            if (gewählteKarte.Count == 0) // Überprüfe ob Karten zum ausspielen gewählt wurden
            {
                return false; 
            }
            gespielteKartenlöschen(); //Lösche die Ausgewählten karten aus der Hand
            return true; 
        }



        protected void gespielteKartenlöschen()
        {

        }

        protected void stapeleinsehen()
        {

        }

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


        public virtual bool isKarosieben()
        {
            return false;
        }
        

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

