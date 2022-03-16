using NUnit.Framework;

namespace SpielleiterTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestSpielleiterKartengenerieren()
        {
            Spielleiter s1 = new Spielleiter();

            s1.spielerhinzufügen();
            
            
            
            
            
            
            
            
            
            s1.kartengenerieren();



            Assert.Pass();
        }
    }
}