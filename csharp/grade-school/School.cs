using System.Collections.Generic;


public class School
{
	public Dictionary<int, List<string>> Roster;

	public School ()
	{
		Roster = new Dictionary<int, List<string>> {};

	}

	public void Add (string student, int grade)
	{
		if(Roster.ContainsKey(grade) == false)
		{
			Roster[grade] = new List<string> {};
		}

		if(Roster[grade].Contains(student) == false)
		{
			Roster[grade].Add(student);
			Roster[grade].Sort();
			
		}

	}

	public List<string> Grade (int grade)
	{
		return Roster.ContainsKey(grade) ? Roster[grade] : new List<string> {};
	}
	
}