class demo1
{
	public double a = 5.12;
}

class demo2
{
	public double b = 10.24;
}

class demoQ3
{
	public static void Main(string[] agrs)
	{
		demo1 obj1 = new demo1();
		demo2 obj2 = new demo2();
		double c = obj1.a+ obj2.b;
		System.Console.WriteLine("{0} + {1} = {2}",obj1.a, obj2.b, c);
	}
}
