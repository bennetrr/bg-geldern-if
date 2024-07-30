public class test
{
    public static WeckStoppUhr uhr = new WeckStoppUhr();
    public static boolean status = true;
    
    public static void main(String args[])
    {
        uhr.setzeZeit(10,5,9);
        uhr.setzeWeckzeit(10,6);
        //
        uhr.weckerAn();
        uhr.stoppuhrAn();
        //
        System.out.println("Weckzeit: " + uhr.gibWeckzeit());
        System.out.println("Wecker-Status: " + uhr.gibWeckerStatus());
        System.out.println("Stoppuhr-Zeit: " + uhr.gibStoppuhrZeit());
        System.out.println("Stoppuhr-Status: " + uhr.gibStoppuhrStatus());
        //
        while(status)
        {
            uhr.erhoeheZeit();
            uhr.testeWeckzeit();
            uhr.erhoeheStoppuhr();
            delay.millisekunden(200);
        }
    }
    
    public static void stopp()
    {
        status = false;
    }
}
