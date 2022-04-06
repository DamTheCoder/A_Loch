using NUnit.Framework;
using A_Loch;

namespace SpielleiterTest
{
    public class kartentest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void KarteWert()
        {
            Karte k7 = new Karte(Kartenwert.Sieben, Kartenfarbe.Karo);
            Assert.AreEqual(7, k7.getWert());
            Assert.AreEqual(Kartenfarbe.Karo, k7.getFarbe());
        }
    }
}