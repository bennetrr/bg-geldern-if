using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchuelerverwaltungProjekt
{
    /**
     * Die Klasse Schueler verwaltet die Daten eines Schülers.
     * Autor:   Martin Lentz
     * Version: 12.02.2014 
     */
    public class Schueler
    {
        // Eigenschaften
        public string Vorname { get; set; }
        public string Name { get; set; }
        public string Geburtsdatum { get; set; }

        // Konstruktor
        public Schueler(string vorname, string name, string geburtsdatum)
        {
            Vorname = vorname;
            Name = name;
            Geburtsdatum = geburtsdatum;
        }

        // Methoden
        public bool matchesSearch(string term)
        {
            return (
                Vorname.ToLower().Contains(term.ToLower()) ||
                Name.ToLower().Contains(term.ToLower()) ||
                Geburtsdatum.ToLower().Contains(term.ToLower())
                );
        }
    }
}