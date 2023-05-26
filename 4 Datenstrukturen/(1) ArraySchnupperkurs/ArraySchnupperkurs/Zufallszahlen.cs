using System;
using System.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace ArraySchnupperkurs
{
    /**
     * Die Klasse Zufallszahlen erzeugt und verwaltet Zahlen.
     * Die Zahlen können statistisch ausgewertet werden.
     * Autor:   ???
     * Version: ???
     */
    public class Zufallszahlen
    {
        // Array zur Speicherung der Zahlen deklarieren
        private int[] zahlen;

        // Deklaration und Erzeugung eines "Zufallsgenerators"
        private Random zufallsgenerator = new Random();

        // <anzahl> Zahlen im Wertebereich von 0 bis 100 erzeugen
        public int[] Erzeugen(int anzahl)
        {
            zahlen = new int[anzahl];
            for (var i = 0; i < anzahl; i++)
            {
                zahlen[i] = zufallsgenerator.Next(0, 100);
            }
            return zahlen;
        }

        // Summe der Zahlen berechnen
        public int Summe()
        {
            // a)
            var summe = 0;
            foreach (var zahl in zahlen)
            {
                summe += zahl;
            }
            return summe;
            
            // c)
            // return zahlen.Sum();
        }

        // Mittelwert der Zahlen berechnen
        public double Mittelwert()
        {
            // a)
            return (double) Summe() / zahlen.Length;
            
            // c)
            // return zahlen.Average();
        }

        // Größte Zahl ermitteln
        public int Max()
        {
            // a)
            var max = 0;
            foreach (var i in zahlen)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
            
            // c)
            // return zahlen.Max();
        }

        // Prüfen, ob <zahl> innerhalb der Zahlen vorhanden ist
        public bool Suchen(int zahl)
        {
            // a)
            foreach (var i in zahlen)
            {
                if (i == zahl) return true;
            }
            return false;
            
            // c)
            // return zahlen.Contains(zahl);
        }
        
        // Zahlen auf- oder absteigend sortieren
        public int[] Sortieren(bool aufsteigend)
        {
            // a)
            // Array.Sort(zahlen);
            // if (!aufsteigend) Array.Reverse(zahlen);
            // return zahlen;
            
            // b)
            // This code sorts the array by swapping the elements if they are not in the correct order.
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var temp = (int[]) zahlen.Clone();
            for (var i = 0; i < temp.Length; i++)
            {
                for (var j = i + 1; j < temp.Length; j++)
                {
                    if (aufsteigend)
                    {
                        if (temp[i] > temp[j])
                        {
                            var temp2 = temp[i];
                            temp[i] = temp[j];
                            temp[j] = temp2;
                        }
                    }
                    else
                    {
                        if (temp[i] < temp[j])
                        {
                            var temp2 = temp[i];
                            temp[i] = temp[j];
                            temp[j] = temp2;
                        }
                    }
                }
            }

            zahlen = temp;
            sw.Stop();
            MessageBox.Show("Sortieren dauerte "+ sw.ElapsedMilliseconds +" Millisekunden");
            return temp;

            // c)
            // if (aufsteigend)
            // {
            //     zahlen = zahlen.OrderBy(i => i).ToArray();
            // }
            // zahlen = zahlen.OrderByDescending(i => i).ToArray();
            // return zahlen;
        }
    }
}