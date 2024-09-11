class PassByValue
{
	public void SetVal(int x)
	{
		Change(x); //Actual parameter
		System.Console.WriteLine( "x = " +x );
	}

	private static void Change(int m) //formal parameter
	{
		m = m+10; 
	}
}

class PassByValueTest
{
	public static void Main()
	{
		PassByValue a = new PassByValue();
		a.SetVal(100);
	}
}

/* 

Output: 

x = 100

*/