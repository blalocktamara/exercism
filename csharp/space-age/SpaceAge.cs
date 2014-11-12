public class SpaceAge
{
	public long Seconds;

	public SpaceAge ()
	{
		Seconds = 0;
	}

	public SpaceAge (long seconds)
	{
		Seconds = seconds;
	}

	public double OnEarth ()
	{
		return Seconds / 60 / 60 / 24 / 365.25;
	}

	public double OnMercury ()
	{
		return OnEarth() / 0.2408467;
	}
	
	public double OnVenus ()
	{
		return OnEarth() / 0.61519726;
	}
	
	public double OnMars ()
	{
		return OnEarth() / 1.8808158;
	}
	
	public double OnJupiter ()
	{
		return OnEarth() / 11.862615;
	}
	
	public double OnSaturn ()
	{
		return OnEarth() / 29.447498;
	}
	
	public double OnUranus ()
	{
		return OnEarth() / 84.016846;
	}
	
	public double OnNeptune ()
	{
		return OnEarth() / 164.79132;
	}
}