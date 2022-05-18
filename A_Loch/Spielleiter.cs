using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    /// <summary>
    /// Der Spielleiter kümmert sich um .... 
    /// </summary>
    public class Spielleiter
    {
        

        List<Karte> kartenstapel = new List<Karte>();
        List<Ablage> ablagestapel = new List<Ablage>();
        List<Spieler> wegKarten = new List<Spieler>();
        List<Spieler> spielerliste = new List<Spieler>();
        List<Spieler> reihenfolge = new List<Spieler>();  
        List<Spieler> spielreihenfolge = new List<Spieler>();
        List<Hand> spielerkarten = new List<Hand>();
        Hand anfangshand = null;
        Ausgespielt gespieltstapel = new Ausgespielt();
        string[] farbe = new string[4];
        int letzteKartegelegt;
        int weristdran;





        /// <summary>
        /// .... unnötig da default Konstr. beim Kompilieren erzeugt wird
        /// </summary>
        public Spielleiter()
        {
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="neuerSpieler"></param>
           public void spielerhinzufügen(Spieler neuerSpieler)
        {
            spielerliste.Add(new Spieler("Lousie1", spielerkarten[0]));
            spielerliste.Add(new Spieler("Louise2", spielerkarten[1]));
            spielerliste.Add(new Spieler("Louise3", spielerkarten[2]));
            spielerliste.Add(new Spieler("Spielername", spielerkarten[3])); //Bezug zur Textbox noch herstellen
        }

        void kartengenerieren()
        {
            foreach (Kartenwert wert in Enum.GetValues(typeof(Kartenwert)))
            {
                foreach (Kartenfarbe farbe in Enum.GetValues(typeof(Kartenfarbe)))
                {
                    anfangshand.Add(new Karte(wert, farbe));
                }
            }
        }


        void kartenmischeln()
        {
            Random rnd = new Random();
            object randomized = anfangshand.OrderBy(item => rnd.Next());

        }


        public void kartenzuteilen(Hand anfangshand)
        {
            while (anfangshand != null)
            {
                int a = 0;
                for (int s = 0; s < 4; s++) // s < Anzahl Spieler
                {
                    spielerkarten[a].Add(anfangshand.getKarte(0));
                    anfangshand.kartenLegen(anfangshand.getKarte(0));
                    a++;
                }
                a = 0;

            }
            //pro Spieler eine Liste
            for (int s = 0; s < 4; s++)
            {

                for (int k = 0; k < 8; k++)
                {
                    spielerkarten[s].Add(anfangshand.getKarte(0));
                    anfangshand.kartenLegen(anfangshand.getKarte(0));
                }//Listen zuteilen 
            }
        }

        public bool spielreihenfolge1() //Reihenfolge zu Beginn des Spiels
        {

            if (spielerliste[3].isKarosieben() == true)
            {
                weristdran = 3;
            }
            else if (spielerliste[0].isKarosieben() == true)
            {
                weristdran = 0;
            }

            else if (spielerliste[1].isKarosieben() == true)
            {
                weristdran = 1;
            }
            else if (spielerliste[2].isKarosieben() == true)
            {
                weristdran = 2;
            }
            letzteKartegelegt = weristdran;
            return false;
            
        }


        public void rundespielen() //Reihenfolge während Runde
        {
            if (kartenstapel.Count != 32)
            {
                for (int a = 0; a < 3; a++)
                {
                    if (spielerliste[letzteKartegelegt].hastdunochkarten() == true) //Bedingung für Abbruch einfügen
                    {
                        spielerliste[letzteKartegelegt].weiterspielen();
                        letzteKartegelegt++;
                        letzteKartegelegt = letzteKartegelegt % 4;
                        a = 0;
                    }
                    else
                    {
                        letzteKartegelegt++;
                        letzteKartegelegt = letzteKartegelegt % 4;
                        a++;
                    }
                }

                if (gespieltstapel.count() != 0)
                {

                    // ablagestapel.Add(gespieltstapel.getKarte(0));
                    // gespieltstapel.kartenLegen(gespieltstapel.getKarte(0));
               
                }


            }
        }

        public void rundenende()
        {
            //return Meme;
        }







    }
}
