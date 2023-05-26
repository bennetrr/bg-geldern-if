import org.junit.jupiter.api.*;
import static org.junit.jupiter.api.Assertions.*;

class HeizungTest {
    Heizung heizung;
    int temp = 25, min = 0, max = 50, schrittweite = 5;



    @BeforeEach
    void setUp() {
        heizung = new Heizung(temp, min, max, schrittweite);
    }

    @AfterEach
    void tearDown() {
        heizung = null;
    }

    @Test
    void testInitialisierung() {
        // Arrange
        // Act
        // Assert
        assertEquals(temp, heizung.gibTemperatur());
        assertEquals(schrittweite, heizung.gibSchrittweite());
    }

    @Test
    void testSetzeSchrittweite() {
        // Arrange
        // Act
        heizung.setzeSchrittweite(3);
        // Assert
        assertEquals(3, heizung.gibSchrittweite());
    }

    @Test
    void testSetzeNegativeSchrittweite() {
        // Arrange
        // Act
        heizung.setzeSchrittweite(-3);
        // Assert
        assertEquals(3, heizung.gibSchrittweite());
    }

    @Test
    void testSetzeSchrittweite0() {
        // Arrange
        // Act
        heizung.setzeSchrittweite(0);
        // Assert
        assertEquals(5, heizung.gibSchrittweite());
    }

    @Test
    void testMinTempUnterschreiten() {
        // Arrange
        // Act
        for (int i = 0; i < 6; i++) heizung.kuehler();
        // Assert
        assertFalse(heizung.gibTemperatur() < min);
    }

    @Test
    void testMinTempUnterschreiten2() {
        // Arrange
        // Act
        heizung.setzeSchrittweite(3);
        for (int i = 0; i < 9; i++) heizung.kuehler();
        // Assert
        assertFalse(heizung.gibTemperatur() < min);
    }

    @Test
    void testMaxTempUeberschreiten() {
        // Arrange
        // Act
        for (int i = 0; i < 6; i++) heizung.waermer();
        // Assert
        assertFalse(heizung.gibTemperatur() < max);
    }

    @Test
    void testMaxTempUeberschreiten2() {
        // Arrange
        // Act
        heizung.setzeSchrittweite(3);
        for (int i = 0; i < 9; i++) heizung.waermer();
        // Assert
        assertFalse(heizung.gibTemperatur() > max);
    }

    @Test
    void testTemperaturErhoehen() {
        // Arrange
        // Act
        heizung.waermer();
        // Assert
        assertEquals(temp + schrittweite, heizung.gibTemperatur());
    }

    @Test
    void testTemperaturSenken() {
        // Arrange
        // Act
        heizung.kuehler();
        // Assert
        assertEquals(temp - schrittweite, heizung.gibTemperatur());
    }

    @Test
    void testMaxTempErreichen() {
        // Arrange
        // Act
        for (int i = 0; i < 5; i++) heizung.waermer();
        // Assert
        assertEquals(max, heizung.gibTemperatur());
    }

    @Test
    void testMinTempErreichen() {
        // Arrange
        // Act
        for (int i = 0; i < 5; i++) heizung.kuehler();
        // Assert
        assertEquals(min, heizung.gibTemperatur());
    }
}