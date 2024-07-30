class IfElseNesting
{
	private int a,b,c;

	public void SetVal(int x,int y, int z)
	{
		a=x;
		b=y;
		c=z;

		System.Console.Write("Largest value is : ");
		Check();		
	}

	private void Check()
	{
		if (a > b)
		{
			if (a > c)
			{
				System.Console.WriteLine(a);
			}
			else
			{
				System.Console.WriteLine(c);
			}
		}		
		else
		{
			if (c > b)
			{
				System.Console.WriteLine(c);
			}
			else
			{
				System.Console.WriteLine(b);
			}
		}
	}

}

class IfElseNestingClient
{
	public static void Main(string[] args)
	{
		IfElseNesting obj = new IfElseNesting();
		obj.SetVal(325, 712, 478);
	}
}

/* 

Output: 

Largest value is : 712

*/