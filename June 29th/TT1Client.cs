class Ty1
{
	// private int a,b;
	// public int a,b;
	// protected int a,b;
	internal int a,b;
}

class TT1Client
{
	public static void Main(string[] agrs)
	{
		Ty1 obj1 = new Ty1();
		obj1.a=5;
		obj1.b=5;		
		System.Console.WriteLine("{0} {1}", obj1.a, obj1.b);
	}
}
