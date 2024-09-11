class Overloading
{
	public void SetVal(int x)
	{
		System.Console.WriteLine(volume(x));
	}

	public void SetVal(float r,int h)
	{
		System.Console.WriteLine(volume(r,h));
	}

	public void SetVal(long l, int b ,int h)
	{
		System.Console.WriteLine(volume(l,b,h));
	}

	private static int volume (int x ) //cube
	{
		return (x* x * x );
	}

	private static double volume(float r,int h ) // cylinder
	{
		return(3.14519*r*r*h);
	}

	private static long volume(long l, int b ,int h ) //box
	{
		return (l*b*h);
	}

}

class MethodOverloadingClient
{
	public static void Main()
	{
		Overloading m = new Overloading();
		m.SetVal(10);
		m.SetVal(2.5F,8);
		m.SetVal(100L,75,15);
	}
}

/* 

Output: 

1000
157.2595
112500

*/