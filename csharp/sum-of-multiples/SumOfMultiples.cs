using System.Collections.Generic;

public class SumOfMultiples
{
	private List<int> divisors;

	public SumOfMultiples ()
	{
		divisors = new List<int> {3, 5};
	}

	public SumOfMultiples (List<int> divisors)
	{
		this.divisors = divisors;
	}

	public int To (int limit)
	{
		int result = 0;

		for(int i = 1; i < limit; i++)
		{
			foreach(int divisor in divisors)
			{
				if(i % divisor == 0)
				{
					result += i;
					break;
				}
			}
		}

		return result;
	}

}