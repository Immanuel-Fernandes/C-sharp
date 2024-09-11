class PassByRef
{
	public void SetVal(int m, int n)
	{
		System.Console.WriteLine("Before Swapping:");
		System.Console.WriteLine("m = "+ m);
		System.Console.WriteLine("n = "+ n);
		Swap(ref m,ref n);
		System.Console.WriteLine("After Swapping:");
		System.Console.WriteLine("m = "+ m);
		System.Console.WriteLine("n = "+ n);
	}

	private static void Swap(ref int x, ref int y )
	{
		int temp = x;
		x=y;
		y = temp;
	}
}

class PassByRefClient
{
	public static void Main()
	{
		PassByRef a = new PassByRef();
		int m = 100;
		int n = 200;
		a.SetVal(m,n);
	}
}

/* 

Output: 

Before Swapping:
m = 100
n = 200
After Swapping:
m = 200
n = 100

*/