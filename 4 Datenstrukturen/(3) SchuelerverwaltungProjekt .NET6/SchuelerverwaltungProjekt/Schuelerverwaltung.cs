using System;
using System.Collections.Generic;

namespace SchuelerverwaltungProjekt;

/**
 * Die Klasse Schuelerverwaltung verwaltet beliebig viele Schüler.
 * Autor:   Martin Lentz
 * Version: 14.02.2019
 */
public class Schuelerverwaltung
{
    private Schueler[] _schuelerDatenstruktur;

    public Schuelerverwaltung()
    {
        _schuelerDatenstruktur = Array.Empty<Schueler>();
    }

    private int Length => _schuelerDatenstruktur.Length;

    public void SchuelerAnmelden(string vorname, string name, string geburtsdatum)
    {
        var temp = new Schueler[Length + 1];
        _schuelerDatenstruktur.CopyTo(temp, 0);
        temp[^1] = new Schueler(vorname, name, geburtsdatum);
        _schuelerDatenstruktur = temp;
    }

    public void SchuelerKorrigieren(int index, string vorname, string name, string geburtsdatum)
    {
        _schuelerDatenstruktur[index] = new Schueler(vorname, name, geburtsdatum);
    }

    public void SchuelerLoeschen(int index)
    {
        var temp = new Schueler[Length - 1];
        for (int i = 0, j = 0; i < Length; i++, j++)
        {
            if (i == index)
            {
                j--;
                continue;
            }
            temp[j] = _schuelerDatenstruktur[i];
        }

        _schuelerDatenstruktur = temp;
    }

    public List<Schueler> SchuelerSuchen(string suchbegriff)
    {
        var results = new List<Schueler>();
        foreach (var schueler in _schuelerDatenstruktur)
        {
            if (schueler.MatchesSearch(suchbegriff)) results.Add(schueler);
        }
        return results;
    }

    public int AnzahlSchueler()
    {
        return Length;
    }

    public Schueler GetSchueler(int index)
    {
        return _schuelerDatenstruktur[index];
    }
}