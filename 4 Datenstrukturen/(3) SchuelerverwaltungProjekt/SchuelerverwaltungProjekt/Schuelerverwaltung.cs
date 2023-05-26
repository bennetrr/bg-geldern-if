using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SchuelerverwaltungProjekt
{
    /**
     * Die Klasse Schuelerverwaltung verwaltet beliebig viele Schüler.
     * Autor:   Martin Lentz
     * Version: 14.02.2019
     */
    public class Schuelerverwaltung
    {
        readonly List<Schueler> schuelerDatenstruktur;

        public Schuelerverwaltung()
        {
            schuelerDatenstruktur = new List<Schueler>();
        }

        public void SchuelerAnmelden(string vorname, string name, string geburtsdatum)
        {
            schuelerDatenstruktur.Add(new Schueler(vorname, name, geburtsdatum));
        }

        public void SchuelerKorrigieren(int index, string vorname, string name, string geburtsdatum)
        {
            schuelerDatenstruktur[index] = new Schueler(vorname, name, geburtsdatum);
        }

        public void SchuelerLoeschen(int index)
        {
            schuelerDatenstruktur.RemoveAt(index);
        }
        
        public List<Schueler> SchuelerSuchen(string suchbegriff)
        {
           return schuelerDatenstruktur.FindAll(s => s.matchesSearch(suchbegriff));
        }
        
        public int AnzahlSchueler()
        {
            return schuelerDatenstruktur.Count;
        }

        public string SchuelerVorname(int index)
        {
            return schuelerDatenstruktur[index].Vorname;
        }

        public string SchuelerName(int index)
        {
            return schuelerDatenstruktur[index].Name;
        }

        public string SchuelerGeburtsdatum(int index)
        {
            return schuelerDatenstruktur[index].Geburtsdatum;
        }
    }
}