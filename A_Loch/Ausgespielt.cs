using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    public class Ausgespielt : Kartenliste
    {
    List<Karte> gespieltstapel;
        public Ausgespielt() : base()   
        {
            gespieltstapel = new List<Karte>();
        }
    public void spielen()
        {
            //gespieltstapel.Add(gewählteKarte)
        }
    }
}
