using System;

public class Triangle
{
	private decimal[] sides;
	public decimal[] Sides
	{
		get { return sides; }
		set {
			sides = value;
			Array.Sort(sides);

			if(sides[0] <= 0 || sides[1] <= 0 || sides[2] <= 0
			|| sides[0] + sides[1] <= sides[2])
			{
				throw new TriangleException();	
			}
		}
	}

	public Triangle (decimal a, decimal b, decimal c)
	{
		Sides = new decimal[] {a, b, c};
	}

	public string Kind ()
	{
		if(Sides[0] == Sides[1] && Sides[1] == Sides[2])
		{
			return TriangleKind.Equilateral;
		}
		else if(Sides[0] == Sides[1] || Sides[1] == Sides[2] || Sides[0] == Sides[2])
		{
			return TriangleKind.Isosceles;
		}

		return TriangleKind.Scalene;
	}


}

public class TriangleException : Exception
{
    public override string Message
    {
        get
        {
            return "This is not a triangle.";
        }
    }

    public TriangleException ()
    {

    }

    public TriangleException (string message)
    {

    }
}

public static class TriangleKind
{
	public static string Equilateral = "Equilateral";
	public static string Isosceles = "Isosceles";
	public static string Scalene = "Scalene";
}