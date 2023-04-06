namespace SchuelerverwaltungProjekt;

/**
 * Die Klasse Schueler verwaltet die Daten eines Schülers.
 * Autor:   Martin Lentz
 * Version: 12.02.2014
 */
public class Schueler
{
    // Konstruktor
    public Schueler(string vorname, string name, string geburtsdatum)
    {
        Vorname = vorname;
        Name = name;
        Geburtsdatum = geburtsdatum;
    }

    // Eigenschaften
    public string Vorname { get; }
    public string Name { get; }
    public string Geburtsdatum { get; }

    // Methoden
    public bool MatchesSearch(string term)
    {
        return Vorname.ToLower().Contains(term.ToLower()) ||
               Name.ToLower().Contains(term.ToLower()) ||
               Geburtsdatum.ToLower().Contains(term.ToLower());
    }
}