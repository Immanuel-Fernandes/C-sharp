class MathTest
{																																															
   	public void SetVal()
   	{
		System.Console.WriteLine("Sines of angles from 0 to 90 degrees");
		Display();
   	}

   	private void Display()
   	{   		       	
		for (double theta=0.0; theta<=90.00; theta+=15)
		{
			double x = System.Math.Sin(theta*System.Math.PI/180);
			System.Console.Write("Sin = " + theta);
			System.Console.WriteLine(" = {0:F4} ",x);
		}
   	}
}

class MathTestCient
{
    public static void Main(string[] args)
    {
      	MathTest obj = new MathTest();
        obj.SetVal();
    }
}


/*

Output:

Sines of angles from 0 to 90 degrees
Sin = 0 = 0.0000
Sin = 15 = 0.2588
Sin = 30 = 0.5000
Sin = 45 = 0.7071
Sin = 60 = 0.8660
Sin = 75 = 0.9659
Sin = 90 = 1.0000

*/

