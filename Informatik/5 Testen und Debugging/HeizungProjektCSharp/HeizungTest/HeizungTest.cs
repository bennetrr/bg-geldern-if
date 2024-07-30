#pragma warning disable CS8602
using HeizungProjektCSharp;

namespace HeizungTest
{
    public class Tests
    {
        private Heizung? heizung;

        [SetUp]  //@BeforeEach
        public void Setup()
        {
            heizung = new Heizung(25, 0, 50, 5);
        }

        [TearDown]  // @AfterEach
        public void TearDown()
        {
            heizung = null;
        }

        [Test(Description = "Testet das initialisieren des Heizung-Objekts")]
        public void TestInitialisierung()
        {
            // Arrange
            // Act
            // Assert
            Assert.Multiple(() =>  // Assert.Multiple, damit alle Tests dieser Methode durchlaufen, auch wenn einer fehlschlägt
            {
                Assert.That(heizung.Temperatur, Is.EqualTo(25));
                Assert.That(heizung.Schrittweite, Is.EqualTo(5));
            });
        }

        [TestCase(3, 3, Description = "Testet das Verändern der Schrittweite")]
        [TestCase(-4, 4, Description = "Testet das Verändern der Schrittweite auf einen negativen Wert")]
        [TestCase(0, 5, Description = "Testet das Verändern der Schrittweite auf 0")]
        public void TestSetzeSchrittweite(int schrittweite, int erwartet)
        {
            // Arrange
            // Act
            heizung.Schrittweite = schrittweite;
            // Assert
            Assert.That(heizung.Schrittweite, Is.EqualTo(erwartet));
        }

        [Test(Description = "Testet, ob die Minimaltemperatur unterschritten werden kann")]
        public void TestMinTempUnterschreiten1()
        {
            // Arrange
            // Act
            for (int i = 0; i < 6; i++) heizung.Kuehler();
            // Assert
            Assert.That(heizung.Temperatur, Is.AtLeast(0));  // heizung.Temperatur >= 0
        }

        [Test(Description = "Testet, ob die Minimaltemperatur unterschritten werden kann")]
        public void TestMinTempUnterschreiten2()
        {
            // Arrange
            // Act
            heizung.Schrittweite = 3;
            for (int i = 0; i < 9; i++) heizung.Kuehler();
            // Assert
            Assert.That(heizung.Temperatur, Is.AtLeast(0));  // heizung.Temperatur >= 0
        }

        [Test(Description = "Testet, ob die Maximaltemperatur überschritten werden kann")]
        public void TestMaxTempUeberschreiten1()
        {
            // Arrange
            // Act
            for (int i = 0; i < 6; i++) heizung.Waermer();
            // Assert
            Assert.That(heizung.Temperatur, Is.AtMost(50));  // heizung.Temperatur <= 50
        }

        [Test(Description = "Testet, ob die Maximaltemperatur überschritten werden kann")]
        public void TestMaxTempUeberschreiten2()
        {
            // Arrange
            // Act
            heizung.Schrittweite = 3;
            for (int i = 0; i < 9; i++) heizung.Waermer();
            // Assert
            Assert.That(heizung.Temperatur, Is.AtMost(50));  // heizung.Temperatur <= 50
        }

        [Test(Description = "Testet, ob die Heizung wärmer gestellt werden kann")]
        public void TestTempErhoehen()
        {
            // Arrange
            // Act
            heizung.Waermer();
            // Assert
            Assert.That(heizung.Temperatur, Is.EqualTo(30));
        }

        [Test(Description = "Testet, ob die Heizung kälter gestellt werden kann")]
        public void TestTempVerringern()
        {
            // Arrange
            // Act
            heizung.Kuehler();
            // Assert
            Assert.That(heizung.Temperatur, Is.EqualTo(20));
        }

        [Test(Description = "Testet, ob die Maximaltemperatur erreicht werden kann")]
        public void TestMaxTempErreichen()
        {
            // Arrange
            // Act
            for (int i = 0; i < 5; i++) heizung.Waermer();
            // Assert
            Assert.That(heizung.Temperatur, Is.EqualTo(50));
        }

        [Test(Description = "Testet, ob die Minimaltemperatur erreicht werden kann")]
        public void TestMinTempErreichen()
        {
            // Arrange
            // Act
            for (int i = 0; i < 5; i++) heizung.Kuehler();
            // Assert
            Assert.That(heizung.Temperatur, Is.EqualTo(0));
        }

        [Test(Description = "Dieser Test wird fehlschlagen")]
        public void TestFailing()
        {
            // Arrange
            // Act
            heizung.Waermer();
            // Assert
            Assert.That(heizung.Temperatur, Is.EqualTo(0));
        }
    }
}