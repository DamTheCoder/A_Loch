using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace A_Loch
{
    internal class Karte
    {
        private int wert;
        private string farbe;

        /// <summary>
        /// Erstelle neue Karte mit Wert w und Farbe f
        /// </summary>
        /// <param name="w">Kartenwert in Zahlen vo 7-14, wobei 11 als Bube, 12 als Dame, 13 als König und 14 als Ass fungiert</param> 
        /// <param name="f">Folgende Farben existieren: Karo, Herz, Pik und Kreuz</param>
        public Karte(int w, string f)
        {
            wert = w;   
            farbe = f; 
        }
        public void KarteZeichnen(Graphics g)
        {
            
        }
    }
}
