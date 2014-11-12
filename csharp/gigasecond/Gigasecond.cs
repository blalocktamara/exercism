using System;

class Gigasecond
{
	private DateTime gigasecondDay;
	public DateTime GigasecondDay {
		get { return gigasecondDay; }
		set {
			gigasecondDay = new DateTime(value.Year, value.Month, value.Day);
		}
	}

	public Gigasecond(DateTime birthday)
	{
		GigasecondDay = birthday.AddSeconds(Math.Pow(10,9));
	}

	public DateTime Date ()
	{
		return GigasecondDay;
	}

}