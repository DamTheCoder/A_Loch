using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace A_Loch
{
    public class Karte
    {
        private Kartenwert wert;
        private Kartenfarbe farbe;
        private Image newImage = Image.FromFile();

         

        /// <summary>
        /// Erstelle neue Karte mit Wert w und Farbe f
        /// </summary>
        /// <param name="w">Kartenwert in Zahlen von 7-14, wobei 11 als Bube, 12 als Dame, 13 als König und 14 als Ass fungiert</param> 
        /// <param name="f">Folgende Farben existieren: Karo, Herz, Pik und Kreuz</param>
        public Karte(Kartenwert kartenwert, Kartenfarbe kartenfarbe)
        {
            wert = kartenwert;   
            farbe = kartenfarbe; 
        }
        public void KarteZeichnen(Graphics g)
        {
            
        }
        public Kartenwert getWert()
        {
            return wert;
        }
        public Kartenfarbe getFarbe()
        {
            return farbe;
        }
    }
}
