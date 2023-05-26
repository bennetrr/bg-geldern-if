using System;
using System.Collections.Generic;
using System.Text;

namespace LottoSimulation
{
    /**
     * Die Klasse Lottospiel simuliert Lottospiele, die in Form eines Abonnements in Auftrag gegeben werden.
     * Autor:   Martin Lentz
     * Version: 08.10.2014
     */
    public class Lottospiel
    {
        private byte[] lottozahlen;

        private Random zufallsgenerator;

        // Führt die Initialisierungen durch, die für die Simulation notwendig sind
        public Lottospiel()
        {
            lottozahlen = new byte[6];
            zufallsgenerator = new Random();
        }

        // Erzeugt die Lottozahlen und sortiert sie in aufsteigender Reihenfolge
        private void ErzeugeLottozahlen()
        {
            int j;
            byte zufallszahl;
            Array.Clear(lottozahlen, 0, lottozahlen.Length);

            for (int i = 0; i < 6; i++)
            {
                do
                {
                    zufallszahl = (byte)zufallsgenerator.Next(1, 50);
                    j = Array.IndexOf(lottozahlen, zufallszahl);
                } while (j > -1);
                lottozahlen[i] = zufallszahl;
            }
            Array.Sort(lottozahlen);
        }

        // Lässt die Lottozahlen erzeugen, überprüft den Tippschein und
        // liefert die Anzahl richtig getippter Zahlen
        private byte SpieleEinLottospiel(byte[] tipp)
        {
            // ...?
        
        
        }

        // Startet ein Abonnement über eine gebuchte Anzahl an Spielen
        public long[] StarteAbonnement(byte[] tipp, long anzahlSpiele)
        {
            long[] spielstatistik = new long[7];
            for (long i = 0; i < anzahlSpiele; i++)
            {
                spielstatistik[SpieleEinLottospiel(tipp)]++;
            }
            return spielstatistik;
        }

        // Startet das Abonnement "Spielen bis 6 Richtige"
        public long[] StarteAbonnement(byte[] tipp)
        {
            // ...?


        }
    }
}