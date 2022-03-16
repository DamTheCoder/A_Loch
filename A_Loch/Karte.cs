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
        public int wert;
        public string farbe;
         

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
