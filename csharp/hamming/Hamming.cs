using System;

public class Hamming
{
	public static int Compute (string strandA, string strandB)
	{
		int result = 0;

		char[] charA= strandA.ToCharArray();
		char[] charB= strandB.ToCharArray();

		for(int i = 0; i < charA.Length; i++)
		{
			if (charA[i] != charB[i])
			{
				result++;
			}

		}

		return result;
	}

}