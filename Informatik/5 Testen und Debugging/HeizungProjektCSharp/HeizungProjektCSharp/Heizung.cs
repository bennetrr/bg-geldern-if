namespace HeizungProjektCSharp;

public class Heizung
{
	private readonly int _min;
	private readonly int _max;
	private int _schrittweite;
	private int _temperatur;

	public int Temperatur
	{
		get => _temperatur;
		private set
		{
			if (value < _min) _temperatur = _min;
			else if (value > _max) _temperatur = _max;
			else _temperatur = value;
		}
	}

	public int Schrittweite
	{
		get => _schrittweite;
		set
		{
			if (value < 0) _schrittweite = -value;
			else if (value == 0) _schrittweite = 5;
			else _schrittweite = value;
		}
	}

	public Heizung(int temperatur = 15, int min = 10, int max = 30, int schrittweite = 5)
	{
		_min = min;
		_max = max;
		_schrittweite = schrittweite;
		Temperatur = temperatur;
	}

	public void Waermer()
	{
		Temperatur += _schrittweite;
	}
	
	public void Kuehler()
	{
		Temperatur -= _schrittweite;
	}
}
