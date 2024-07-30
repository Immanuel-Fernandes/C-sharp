class Expressions
{
	private int a, b, c, d;
    private float x, y;
    
    private int answer1, answer2, answer3;
	private float answer4;
	private bool bool1, bool2, bool3, bool4;	

    public void SetVal(int a1, int b1, int c1, int d1, float x1, float y1)
    {
        a = a1;
        b = b1;
        c = c1;
        d = d1;
        x = x1;
        y = y1;
        Operations();
        Display();
    }

	private void Operations()
	{	
		// Order of Evaluation
		answer1 = a * b + c / d;
		answer2 = a * (b + c) / d;

		// Modulo Operations
		answer3 = a % c;
		answer4 = x % y;

		// Logical Operations
		bool1 = a > b && c > d;
		bool2 = a < b && c > d;
		bool3 = a < b || c > d;
		bool4 = !(a-b == c);
	}

	private void Display()
	{	
		System.Console.WriteLine("Order of Evaluation");
		System.Console.WriteLine(" a * b + c / d = " + answer1);
		System.Console.WriteLine(" a * (b + c) / d = " + answer2);

		System.Console.WriteLine("Modulo Operations");
		System.Console.WriteLine(" a % c = "+ answer3);
		System.Console.WriteLine(" x % y = "+ answer4);

		System.Console.WriteLine("Logical Operations");
		System.Console.WriteLine(" a > b && c > d = "+ bool1);
		System.Console.WriteLine(" a < b && c > d = "+ bool2);
		System.Console.WriteLine(" a < b || c > d = " + bool3);
		System.Console.WriteLine(" !(a-b) == c = "+ bool4);
	}	
}

class ExpressionsCient
{
	public static void Main(string[] args)
	{
		Expressions obj = new Expressions();
		obj.SetVal(10,5,8,2,6.4F,3.0F);
	}
}


/*

Output:

Order of Evaluation
 a * b + c / d = 54
 a * (b + c) / d = 65
Modulo Operations
 a % c = 2
 x % y = 0.4000001
Logical Operations
 a > b && c > d = True
 a < b && c > d = False
 a < b || c > d = True
 !(a-b) == c = True

 */