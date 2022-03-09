using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    internal class Kartenliste
    {
        protected List<Karte> kartenliste;
        public Kartenliste()
        {}

        public void Add(Karte neueKarte)
        {
            kartenliste.Add(neueKarte);
        }
        public void Clear()
        {
            kartenliste.Clear();
        }
    }
}
