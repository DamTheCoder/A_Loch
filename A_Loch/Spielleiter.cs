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
        List<Spieler> spielerliste;
        List<Spieler> reihenfolge;   
        List<Hand> spielerkarten;
        Hand anfangshand = null;
        string[] farbe = new string[4];

            spielerliste = new List<Spieler>();
            reihenfolge = new List<Spieler>();
            spielerkarten = new List<Hand>();




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
            anfangshand = new Hand();

            int u = 0;
            for (int f = 0; f < 4; f++)
            {

                for (int i = 7; i < 15; i++)
                {
                    String farbeq = farbe[u];
                    anfangshand.Add(new Karte(i, farbeq));

                }
                u++;
            }
            



        }

        void kartenmischeln()
        {
            Random rnd = new Random();
            object randomized = anfangshand.OrderBy(item => rnd.Next());

        }


        public void kartenzuteilen(Hand anfangshand)
        {
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

        public bool spielreihenfolge1()
        {
            
            if (spielerliste[3].isKarosieben() == true)
            {
                reihenfolge.Add(spielerliste[3]);
                reihenfolge.Add(spielerliste[0]);
                reihenfolge.Add(spielerliste[1]);
                reihenfolge.Add(spielerliste[2]);
            }
            else if (spielerliste[0].isKarosieben() == true)
            {
                reihenfolge.Add(spielerliste[0]);
                reihenfolge.Add(spielerliste[1]);
                reihenfolge.Add(spielerliste[2]);
                reihenfolge.Add(spielerliste[3]);
            }
            else if (spielerliste[1].isKarosieben() == true)
            {
                reihenfolge.Add(spielerliste[1]);
                reihenfolge.Add(spielerliste[2]);
                reihenfolge.Add(spielerliste[3]);
                reihenfolge.Add(spielerliste[0]);
            }
            else if (spielerliste[2].isKarosieben() == true)
            {
                reihenfolge.Add(spielerliste[2]);
                reihenfolge.Add(spielerliste[3]);
                reihenfolge.Add(spielerliste[0]);
                reihenfolge.Add(spielerliste[1]);
            }
            
            return false;
        }

        public void reihenfolgegenerieren()
        {
            
            
        }

        public void rundenende()
        {
            //return Meme;
        }

        void rangliste()
        {
           
        }







    }
}
