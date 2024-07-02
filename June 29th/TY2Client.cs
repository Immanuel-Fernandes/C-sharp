class Ty1
{
	private int var1,var2;
	public void AssignValue()
	{
		var1=0;
		var2=0;		
		System.Console.WriteLine("{0} {1}", var1, var2);

	}

	public void AssignValue(int v1, int v2)  // Public Member function
	{
		var1=v1;
		var2=v2;		
		System.Console.WriteLine("{0} {1}", var1, var2);

	}
}

class TY2Client
{
	public static void Main(string[] agrs)
	{
		Ty1 obj1 = new Ty1();
		obj1.AssignValue();
		int a=10, b=5;	
		obj1.AssignValue(a,b);	
		//System.Console.WriteLine("{0} {1}", obj1.a, obj1.b);
	}
}
