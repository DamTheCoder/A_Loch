using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    public class Hand : Kartenliste
    {
        public Hand() : base()  
        {
        
        }

        /// <summary>
        /// kartenLegen entfernt gewählte Karte(n) aus der Liste
        /// </summary>
        /// <param name="gewählteKarte"></param>
        public void kartenLegen(Karte gewählteKarte) 
        {
            kartenliste.Remove(gewählteKarte);
        }

        internal object OrderBy(Func<object, int> p)
        {
            throw new NotImplementedException();
        }
    }
}
