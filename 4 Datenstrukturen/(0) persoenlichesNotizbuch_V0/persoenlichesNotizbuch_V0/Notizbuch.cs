using System.Collections.Generic;
using System.IO;

namespace persoenlichesNotizbuch_V0
{
    /**
     * Die Klasse Notizbuch verwaltet beliebig lange Notizlisten.
     * Die Notizen sind nummeriert, um referenziert werden zu können.
     * In dieser Version starten die Notiznummern bei 0.
     * Autor:   Martin Lentz
     * Version: 01.03.2016
     */
    public class Notizbuch
    {
        // Speicher für eine beliebige Anzahl an Notizen
        private List<string> notizen;

        // Führt die Initialisierungen durch, die für ein Notizbuch notwendig sind
        public Notizbuch()
        {
            notizen = new List<string>();
        }

        // Speichert eine neue Notiz in diesem Notizbuch
        public void SpeichereNotiz(string notiz)
        {
            notizen.Add(notiz);
        }

        // Liefert die Anzahl der Notizen in diesem Notizbuch
        public int AnzahlNotizen()
        {
            return notizen.Count;
        }

        // Zeigt die Notiz mit der Notiznummer <index> an
        public string ZeigeNotiz(int index)
        {
            return notizen[index];
        }

        // Löscht die Notiz mit der Notiznummer <index>
        public void LoescheNotiz(int index)
        {
            notizen.RemoveAt(index);
        }

        // Löscht alle Notizen
        public void LoescheAlleNotizen()
        {
            notizen.Clear();
        }

        // Ersetzt die Notiz mit der Notiznummer <index>
        public void ErsetzeNotiz(int index, string notiz)
        {
            notizen[index] = notiz;
        }

        // Durchsucht die Notizen nach einem Suchbegriff und liefert das Ergebnis der Suche zurück
        public List<string> SucheNotizen(string suchbegriff)
        {
            return notizen.FindAll(s => s.ToLower().Contains(suchbegriff.ToLower()));
            // List<string> suchergebnisse = new List<string>();
            // foreach (var s in notizen)
            // {
            //     if (s.ToLower().Contains(suchbegriff.ToLower()))
            //     {
            //         suchergebnisse.Add(s);
            //     }
            // }
            //
            // return suchergebnisse;
        }

        public void InDateiSpeichern()
        {
            FileStream fileStream = new FileStream("notizen.json", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileStream);
            notizen.ForEach(notiz => writer.WriteLine(notiz));
            writer.Close();
            fileStream.Close();
        }
        
        public void AusDateiLesen()
        {
            FileStream fileStream = new FileStream("notizen.json", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            while (reader.Peek() != -1)
            {
                SpeichereNotiz(reader.ReadLine());
            }
            fileStream.Close();
        }
    }
}