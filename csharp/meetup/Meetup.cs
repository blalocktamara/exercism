using System;

public class Meetup
{

	public int Month;
	public int Year;

	public static void Main ()
	{
		Console.WriteLine(new Meetup(11, 2014).Day(DayOfWeek.Monday, Schedule.Last));
	}

	public Meetup ()
	{

	}

	public Meetup (int month, int year)
	{
		Month = month;
		Year = year;
	}

	public DateTime Day (DayOfWeek dayOfWeek, string modifier)
	{
		DateTime result = new DateTime(Year, Month, 1);

		int resultDay = (int)result.DayOfWeek;
		int modifierDay = (int)dayOfWeek;

		if(modifier.Equals(Schedule.Last))
		{
			result = result.AddMonths(1).AddDays(-1);
			resultDay = (int)result.DayOfWeek;

			if(modifierDay > resultDay)
			{
				return result.AddDays((7 + resultDay - modifierDay) * -1);
			}

			return result.AddDays((resultDay - modifierDay) * -1);
		}


		if(modifier.Equals(Schedule.Second))
		{
			result = result.AddDays(7);
		}
		else if(modifier.Equals(Schedule.Teenth))
		{
			result = result.AddDays(12);
		}
		else if(modifier.Equals(Schedule.Third))
		{
			result = result.AddDays(14);
		}
		else if(modifier.Equals(Schedule.Fourth))
		{
			result = result.AddDays(21);

		}

		resultDay = (int)result.DayOfWeek;

		if(modifierDay < resultDay)
		{
			return result.AddDays(7 + modifierDay - resultDay);
		}

		return result.AddDays(modifierDay - resultDay);
	}

}

public static class Schedule
{
	public static string First = "first";
	public static string Second = "second";
	public static string Teenth = "teenth";
	public static string Third = "third";
	public static string Fourth = "fourth";
	public static string Last = "last";

}