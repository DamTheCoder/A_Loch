using NUnit.Framework;
using A_Loch;

namespace SpielleiterTest
{
    /// <summary>
    /// testet Klasse Hand
    /// @author Louis
    /// </summary>
    public class handtest
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Hand()
        {
            Karte p8 = new Karte(Kartenwert.Acht, Kartenfarbe.Pik);
            Karte k14 = new Karte(Kartenwert.Ass, Kartenfarbe.Kreuz);
            Karte h10 = new Karte(Kartenwert.Zehn, Kartenfarbe.Herz);
            Hand h1 = new Hand();
            h1.Add(p8);
            h1.Add(k14);
            h1.Add(h10);
            h1.kartenLegen(k14);
            h1.count();
            Assert.AreEqual(2, h1.count());
        }
    }
}