import static org.junit.Assert.*;
import org.junit.After;
import org.junit.Before;
import org.junit.Test;

/**
 * Die Test-Klasse TestDigitaluhr.
 *
 * @author  Martin Lentz
 * @version 20.04.2018
 */
public class TestDigitaluhr
{
    private WeckStoppUhr weckStoppUhr;
    
    public TestDigitaluhr() {}

    @Before
    public void setUp()
    {
         weckStoppUhr = new WeckStoppUhr();
    }

    @After
    public void tearDown()
    {
        weckStoppUhr = null;
    }

    @Test
    public void Test_0() // Prüft, ...?
    {
        assertEquals("0 : 0 : 0", weckStoppUhr.uhr_gibUhrzeit());
        assertEquals("0 : 0 : 0", weckStoppUhr.wecker_gibWeckzeit());
        assertEquals("0 : 0 : 0", weckStoppUhr.stoppuhr_gibStoppuhrzeit());
        assertEquals(false, weckStoppUhr.wecker_gibWeckerEingeschaltet());
        assertEquals(false, weckStoppUhr.wecker_gibAlarm());
        assertEquals(false, weckStoppUhr.stoppuhr_gibStoppuhrLaeuft());        
    }
    
    @Test
    public void Test_1() // Prüft, ...?
    {
        for (int i = 0; i < 25; i++)
        {
            weckStoppUhr.erhoeheZeit();
        }
        assertEquals("0 : 0 : 25", weckStoppUhr.uhr_gibUhrzeit());
    }
    
    
    @Test
    public void Test_2() // Prüft, ...?
    {
        for (int i = 0; i < 60; i++)
        {
            weckStoppUhr.erhoeheZeit();
        }
        assertEquals("0 : 1 : 0", weckStoppUhr.uhr_gibUhrzeit());
    }
    
    @Test
    public void Test_3() // Prüft, ...?
    {
        for (int i = 0; i < 3600; i++)
        {
            weckStoppUhr.erhoeheZeit();
        }
        assertEquals("1 : 0 : 0", weckStoppUhr.uhr_gibUhrzeit());
    }
    
    @Test
    public void Test_4() // Prüft, ...?
    {
        for (int i = 0; i < 86400; i++)
        {
            weckStoppUhr.erhoeheZeit();
        }
        assertEquals("0 : 0 : 0", weckStoppUhr.uhr_gibUhrzeit());
    }
    
    @Test
    public void Test_5() // Prüft, ...?
    {
        weckStoppUhr.uhr_setzeUhrzeit(8, 30, 45);
        assertEquals("8 : 30 : 45", weckStoppUhr.uhr_gibUhrzeit());
    }    
    
    @Test
    public void Test_6() // Prüft, ...?
    {
        weckStoppUhr.uhr_setzeUhrzeit(23, 59, 59);
        assertEquals("23 : 59 : 59", weckStoppUhr.uhr_gibUhrzeit());
    }
    
    @Test
    public void Test_7() // Prüft, ...?
    {
        weckStoppUhr.uhr_setzeUhrzeit(99, 99, 99);
        assertEquals("0 : 0 : 0", weckStoppUhr.uhr_gibUhrzeit());
    }
}