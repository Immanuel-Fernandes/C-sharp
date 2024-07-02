class Demo
{
	public double one=12.5;
}

class Demo1
{
	public double two=35.4;
}

class Sum_d
{
	public static void Main(string[] args)
	{ 		
		Demo b2=new Demo();
		Demo1 b3=new Demo1();

		double third=b2.one+b3.two;
	
		System.Console.WriteLine("{0} + {1} = {2}",b2.one,b3.two,third);
		
	}
}