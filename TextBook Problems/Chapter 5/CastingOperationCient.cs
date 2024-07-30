class CastingOperation
{
    private float sum; 
	int i;																																																		

    public void SetVal(int n1)
    {
        sum = 0.0F;
		i=n1;
		Display();
    }

    private void Display()
    {
        for (i=1;i<=10;i++)
		{
			sum=sum+1/(float)i;
			System.Console.Write(" i = " + i);
			System.Console.WriteLine(" Sum = " + sum);
		}
    }
}

class CastingOperationCient
{
    public static void Main(string[] args)
    {
        CastingOperation obj = new CastingOperation();
        
        System.Console.Write("Enter number i: ");
		int i = int.Parse(System.Console.ReadLine());
        
        obj.SetVal(i);
    }
}


/*

Output:

Enter number i: 10
 i = 1 Sum = 1
 i = 2 Sum = 1.5
 i = 3 Sum = 1.833333
 i = 4 Sum = 2.083333
 i = 5 Sum = 2.283334
 i = 6 Sum = 2.45
 i = 7 Sum = 2.592857
 i = 8 Sum = 2.717857
 i = 9 Sum = 2.828969
 i = 10 Sum = 2.928968

*/

