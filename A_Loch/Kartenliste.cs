using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    public class Kartenliste
    {
        protected List<Karte> kartenliste;
        public Kartenliste()
        {
            kartenliste = new List<Karte>();
        }

        public void Add(Karte neueKarte)
        {
            kartenliste.Add(neueKarte);
        }
        public void Clear()
        {
            kartenliste.Clear();
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
    }
}
