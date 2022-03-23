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

        [Test]
        public void Spieler()
        {
            Hand h1 = new Hand();
            Spieler s1 = new Spieler("Jürgen", h1);
            Assert.Pass();
        }
        [Test]
        public void Hand()
        {
            Hand h1 = new Hand();
            Assert.Pass();
        }
        private const int wert = 7;
        [Test]
        public void KarteWert()
        {
            Karte k7 = new Karte(7, "Karo");
            k7.getWert();
            Assert.AreEqual(wert, k7.getWert());
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