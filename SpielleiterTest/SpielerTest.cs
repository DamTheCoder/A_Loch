using NUnit.Framework;
using A_Loch;

namespace SpielleiterTest
{
    public class Spielertest
    {
        [SetUp]
        public void Setup()
        {
        }

        /*[Test]
        public void Spieler()
        {
            Hand h1 = new Hand();
            Spieler s1 = new Spieler("Jürgen", h1);
            Assert.Pass();
        }
        private const int Anzahl = 2;
        [Test]
        public void Hand()
        {
            Karte p8 = new Karte(8, "Pik");
            Karte k14 = new Karte(14, "Kreuz");
            Karte h10 = new Karte(10, "Herz");
            Hand h1 = new Hand();
            h1.Add(p8);
            h1.Add(k14);
            h1.Add(h10);
            h1.kartenLegen(k14);
            h1.count();
            Assert.AreEqual(Anzahl, h1.count());
        }*/
        
        [Test]
        public void KarteWert()
        {
            Karte k7 = new Karte(7, "Karo");
            //k7.getWert();
            Assert.AreEqual(7, k7.getWert());
            Assert.AreEqual(Kartenfarbe.Karo, k7.getFarbe);

        }
        private const string farbe = "Karo";
        public void KarteFarbe()
        {
            Karte k7 = new Karte(7, "Karo");
            k7.getFarbe();
            Assert.AreEqual(farbe, k7.getFarbe());
        }
    }
}