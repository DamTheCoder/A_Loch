using NUnit.Framework;
using A_Loch;

namespace SpielleiterTest
{
    /// <summary>
    /// testet Klasse Spieler
    /// @author Louis
    /// </summary>
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
            Karte p8 = new Karte(Kartenwert.Acht, Kartenfarbe.Pik);
            Karte k14 = new Karte(Kartenwert.Ass, Kartenfarbe.Kreuz);
            Karte h10 = new Karte(Kartenwert.Zehn, Kartenfarbe.Herz);
            Karte k7 = new Karte(Kartenwert.Sieben, Kartenfarbe.Karo);
            h1.Add(p8);
            h1.Add(k14);
            h1.Add(h10);
            h1.Add(k7);
            Spieler s1 = new Spieler("Jürgen", h1);
            s1.hastdunochkarten();
            Assert.AreEqual(true, s1.hastdunochkarten());
            s1.isKarosieben();
            Assert.AreEqual(true, s1.isKarosieben());
        }
    }
}