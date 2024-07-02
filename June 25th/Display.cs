class Demo
{
	public string one="C#";
}

class Demo1
{
	public string two="Programming";
}

class Display
{
	public static void Main(string[] args)
	{ 		
		Demo b2=new Demo();
		Demo1 b3=new Demo1();
	
		System.Console.WriteLine("{0} {1}",b2.one,b3.two);
		
	}
}