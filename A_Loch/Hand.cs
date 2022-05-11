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
        /// kartenSortieren sortiert die karten nach Wert, beginnend mit der niedrigsten Karten
        /// </summary>
        public void kartenSortieren()
        {
            kartenliste.OrderBy(x => x.getWert());
        }

        /// <summary>
        /// kartenLegen entfernt gewählte Karte(n) aus der Liste
        /// </summary>
        /// <param name="gewählteKarte">Karte(n), welche vom Spieler ausgewählt wurde(n)</param>
        public void kartenLegen(Karte gewählteKarte) 
        {
            kartenliste.Remove(gewählteKarte);
        }

        public int count() 
            {
            return kartenliste.Count();
            }

        public Karte getKarte(int i)
        {
            if (i <= this.count())
                return kartenliste[i]; 
            else
                return null;
        }
        internal object OrderBy(Func<object, int> p)
        {
            throw new NotImplementedException();
        }
    }
}
