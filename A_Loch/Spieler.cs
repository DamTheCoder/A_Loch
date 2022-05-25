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

        public void kartenwaehlen(int x, int y) //fügt die Karten auf die der Spieler klickt der Liste gewählte Karte hinzu
        {

            
            for (int k = 0; k < 7; k++)//Alle Karten durchgehen
            {
                if(y <= hand.getKarte(k).karte_offset)
                {

                    
                    if (k == 0)
                        {
                            if(x <= hand.getKarte(0).getBreite()) //Liegt der Zeiger auf der ersten Karte?
                            {
                                bool a = hand.getKarte(k).getGewaehlt();//Ruft ab ob die karte bereits ausgewaehlt wurde
                                hand.getKarte(k).setGewaehlt(a);//Ändert den Gewaehltstatus der Karte
                            }
                        }
                        else
                        {
                            if(x >= (k - 1) * hand.getKarte(k).getBreite() + (k - 1) * hand.getKarte(k).karte_offset && x<= k * hand.getKarte(k).getBreite() + k * hand.getKarte(k).karte_offset)//Auf welcher Karte liegt der Zeiger
                            {
                                bool a = hand.getKarte(k).getGewaehlt();//Ruft ab ob die karte bereits ausgewaehlt wurde
                                hand.getKarte(k).setGewaehlt(a);//Ändert den Gewaehltstatus der Karte
                            }
                    }
                }

            } 
            

             

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
        
        

      

        

 

    }


}

