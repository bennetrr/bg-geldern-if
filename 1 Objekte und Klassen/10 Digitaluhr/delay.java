public class delay {
    public static void sekunden(int sekunden) {
        try {
            Thread.sleep(sekunden * 1000);
        } catch (InterruptedException e) {
            System.out.println("Ein Fehler ist aufgetreten");
        }
    }
    
    public static void millisekunden(int millisekunden) {
        try {
            Thread.sleep(millisekunden);
        } catch (InterruptedException e) {
            System.out.println("Ein Fehler ist aufgetreten");
        }
    }
}