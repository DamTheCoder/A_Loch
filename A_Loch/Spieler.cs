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
        public Hand handliste;

        public Spieler(string n, Hand h1)
        {
            Name = n; //txtName: die Textbox zum Namen reinschreiben
            handliste = h1; //Übernimmt Liste von Karten vom Spielleiter
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
            if (handliste.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool isKarosieben()
        {
            for (int i = 0; i < handliste.Count; i++)
            {
            
                if (handliste[i].wert == 7)
                {
                    if (handliste[i].farbe == "Karo")
                    {
                        return true;
                    }
                    
                }
                
                

            }
            return false;


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

