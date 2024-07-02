class demo1
{
	public string str1 = "C#";
}

class demo2
{
	public string str2 = "Programing";
}

class demo
{
	public static void Main(string[] agrs)
	{
		demo1 obj1 = new demo1();
		demo2 obj2 = new demo2();
		System.Console.WriteLine("{0} {1}", obj1.str1, obj2.str2);
	}
}
