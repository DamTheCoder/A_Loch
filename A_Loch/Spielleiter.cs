using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Loch
{
    public class Spielleiter
    {

        List<Karte> kartenstapel;
        List<Spieler> spielerliste;
        List<Spieler> reihenfolge;
        List<Hand> spielerkarten;
        Hand anfangshand;
        string[] farbe = new string[4];






        public Spielleiter()
        {
            kartenstapel = new List<Karte>();
            spielerliste = new List<Spieler>();
            reihenfolge = new List<Spieler>();
            spielerkarten = new List<Hand>();
            farbe[0] = "Karo";
            farbe[1] = "Herz";
            farbe[2] = "Pik";
            farbe[3] = "Kreuz";

        }

        
        
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
            var rnd = new Random();
            var randomized = anfangshand.OrderBy(item => rnd.Next());

        }

        public void kartenzuteilen()
        {
            //pro Spieler eine Liste
            for (int s = 0; s < 4; s++)
            {
                
                for (int k = 0; k < 8; k++)
                {
                    spielerkarten[s].Add(anfangshand[0]);
                    anfangshand.Kartenlegen[0];
                }//Listen zuteilen 
            }
        }

        public override bool isKarosieben ()
        {
            for (int i = 0; i < spielerliste.Count; i++)
            {
                
                if (spielerliste[i] == 7)
                {
                    if (spielerliste[i] == farbe[0])
                    {
                        return true;
                    }

                }



            }
            return false;
        }

        public void  k7Sucher()
        {


           // return Spieler;
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
