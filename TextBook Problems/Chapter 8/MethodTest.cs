class Method 
{
	public int SetVal(int z)
    {
        return Cube(z);
    }

    private int Cube(int x)
	{
		return(x * x * x);
	}
}

class MethodTest
{	
	public static void Main( )
	{
		Method M = new Method ( );
		int y = M.SetVal(5); 
		System.Console.WriteLine(y);
	}
}

/* 

Output: 

125

*/