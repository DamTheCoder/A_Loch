﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

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

        internal object OrderBy(Func<object, int> p)
        {
            throw new NotImplementedException();
        }
        public void KarteZeichnen(PaintEventArgs e, Panel p)
        {
            int x_off = -136;
            foreach(Karte k1 in kartenliste)
            {
                k1.DrawImage(e,  p, x_off = x_off + k1.karte_offset);
                               
            }
        }
    }
}
