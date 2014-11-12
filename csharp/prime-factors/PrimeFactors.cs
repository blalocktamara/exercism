using System;
using System.Collections.Generic;

public static class PrimeFactors {
	
	public static int[] For (long test)
	{
		List<int> result = new List<int> {};

		for(int i = 2; i <= test; i++)
		{
			if(test % i == 0)
			{
				result.Add(i);
				test /= i;
				i = 1;
			}

		}

		return result.ToArray();
	}

}