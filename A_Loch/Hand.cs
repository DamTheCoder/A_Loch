using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    internal class Hand : Kartenliste
    {
        public void Kartenlegen(Karte gewählteKarte)
        {
            kartenliste.Remove(gewählteKarte);
        }

    }
}
