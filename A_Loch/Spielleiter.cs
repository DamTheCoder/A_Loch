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
        List<Hand> hand;
        Hand anfangshand;
        string[] farbe = new string[4];






        public Spielleiter()
        {
            kartenstapel = new List<Karte>();
            spielerliste = new List<Spieler>();
            reihenfolge = new List<Spieler>();
            hand = new List<Hand>();
            farbe[0] = "Karo";
            farbe[1] = "Herz";
            farbe[2] = "Pik";
            farbe[3] = "Kreuz";

        }

        void spielerhinzufügen(Spieler neuerSpieler)
        {
            spielerliste.Add(new Spieler("Lousie1", hand[0]));
            spielerliste.Add(new Spieler("Louise2", hand[1]));
            spielerliste.Add(new Spieler("Louise3", hand[2]));
            spielerliste.Add(new Spieler("Spielername", hand[3]));
        }

        void kartengenerieren()
        {
            anfangshand = new Hand();

            for (int f = 0; f < 4; f++)
            {
                
                for (int i = 7; i < 15; i++)
                {
                    int u = 0;
                    String farbeq = farbe[u];
                    anfangshand.Add(new Karte(i, farbeq));
                    u++;

                }
            }
            



        }

        void kartenmischeln()
        {

            
        }

        public kartenzuteilen()
        {
            //pro Spieler eine Liste
            return;
        }

        public Spieler k7Sucher()
        {
            return Spieler;
        }

        public reihenfolge()
        {
            return List<Reihenfolge>;
        }

        public rundenende()
        {
            return Meme;
        }

        void rangliste()
        {
           
        }







    }
}
