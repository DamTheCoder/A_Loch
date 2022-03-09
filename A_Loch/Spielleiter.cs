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






        public Spielleiter()
        {
            kartenstapel = new List<Karte>();
            spielerliste = new List<Spieler>();
            reihenfolge = new List<Spieler>();
            spielerkarten = new List<Hand>();

        }

        void spielerhinzufügen(Spieler neuerSpieler)
        {
            spielerliste.Add(new Spieler("Louise1", spielerkarten[0]));
            spielerliste.Add(new Spieler("Louise2", spielerkarten[1]));
            spielerliste.Add(new Spieler("Louise3", spielerkarten[2]));
            spielerliste.Add(new Spieler(Spielername, spielerkarten[3]));
        }

        void kartengenerieren()
        {
            anfangshand = new Hand();
            anfangshand.Add(new Karte(7, "Karo"));
            anfangshand.Add(new Karte(8, "Karo"));









        }

        void kartenmischeln()
        {
            
        }

        public kartenzuteilen()
        {
            //pro Spieler eine Liste
        }

        public k7Sucher()
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
