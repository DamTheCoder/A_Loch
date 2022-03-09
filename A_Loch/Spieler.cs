using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
   
    
    internal class Spieler
    {
        public string Name;
        public List<Karte> hand;

        public Spieler(string Name, List hand)
        {
            Name = txtName.text; //txtName: die Textbox zum Namen reinschreiben
            hand = hand; //Übernimmt Liste von Karten vom Spielleiter
        }

        protected void kartensortieren()
        {

        }

        public bool weiterspielen()
        {
            return true;
        }

        protected void gespielteKartenlöschen()
        {

        }

        protected void stapeleinsehen()
        {

        }

        public bool hastdunochkarten()
        {
            return true;
        }

        public bool karosieben()
        {
            
            return true;
        }

        public int status()
        {
            return 0;
        }

        public string kommentar()
        {
            return "Der geht auf die Dörfer";
        }

        public string ergebnis()
        {
            return "Du hast verkackt";
        }
    }
}
