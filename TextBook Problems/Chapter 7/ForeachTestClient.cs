class ForeachTest
{
	private int[] arrayInt;

	public void SetVal(int[] z)
    {
        arrayInt=z;
        Display();
    }

    private void Display()
    {
	
		foreach ( int m in arrayInt)
		{
			System.Console.Write(" " +m);
		}
		System.Console.WriteLine( );
	}
}

class ForeachTestClient
{
    public static void Main(string[] args)
    {
        ForeachTest obj = new ForeachTest();
		int[] x = {11, 22, 33, 44};
        obj.SetVal(x);        
    }
}

/* 

Output: 

 11 22 33 44

*/