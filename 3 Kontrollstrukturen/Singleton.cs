using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo
{
	/**
	 * Die Klasse Singleton garantiert,
	 * dass nur genau ein Objekt von ihr erzeugt werden kann.
	 * Autor:   Martin Lentz
	 * Version: 23.05.2006
	 */
	public class Singleton
	{
		// Eigenschaften
		private int wert;
		public int Wert
		{
			set
			{
				wert = value;
			}
			get
			{
				return wert;
			}
		}

		// Klasseneigenschaft, speichert die Referenz auf das einzige Objekt.
		private static Singleton einzigesObjekt = null;
		
		// Konstruktor, von auﬂen nicht sichtbar.
		private Singleton()
		{
		}

		// Klassenmethode, die die Objektreferenz liefert;
		// wenn Objekt noch nicht existiert, wird es erzeugt.
		public static Singleton GibObjekteferenz()
		{
			if(einzigesObjekt == null)
			{
				einzigesObjekt = new Singleton();
			}
			return einzigesObjekt;
		}
	}
}