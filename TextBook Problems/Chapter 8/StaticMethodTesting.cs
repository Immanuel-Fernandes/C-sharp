class StaticMethod 
{
	public float SetVal(float z)
    {
        return Square(z); //call
    }

    private static float Square(float x) //definition
	{
		return(x * x);
	}
}

class StaticMethodTesting
{
	public static void Main()
	{
		StaticMethod M = new StaticMethod(); 
		double y = M.SetVal(2.5F); 
		System.Console.WriteLine(y);
	}
}

/* 

Output: 

6.25

*/