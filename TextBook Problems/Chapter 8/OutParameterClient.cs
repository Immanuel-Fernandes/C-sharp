class Output
{
	public void SetVal(int m)
	{
		Square (10, out m);
		System.Console.WriteLine("m = "+m);
	}

	private static void Square(int x, out int y)
	{
		y = x*x;
	}
}

class OutParameterClient
{
	public static void Main()
	{
		Output a = new Output();
		int m = 10;
		a.SetVal(m);
	}
}

/* 

Output: 

m = 100

*/