﻿using System;
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

        public Spieler(string n, List<Karte> h)
        {
            Name = n; //txtName: die Textbox zum Namen reinschreiben
            hand = h; //Übernimmt Liste von Karten vom Spielleiter
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
            if (hand.Count > 0)
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
            for (int i = 0; i < hand.Count; i++)
            {
            
                if (hand[i].wert == 7)
                {
                    if (hand[i].farbe == "karo")
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

