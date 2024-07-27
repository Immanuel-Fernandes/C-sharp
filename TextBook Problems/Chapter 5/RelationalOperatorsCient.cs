class RelationalOperators
{
    private float a, b, c; 

    public void SetVal(float n1, float n2, float n3)
    {
        a=n1;
		b=n2;
		c=n3;
		Display();
    }

    private void Display()
    {
        System.Console.WriteLine(" a = "+ a); 
		System.Console.WriteLine(" b = "+ b); 
		System.Console.WriteLine(" c = "+ c); 

		System.Console.WriteLine(" a < b is " + (a < b));
		System.Console.WriteLine(" a > b is " + (a > b)); 
		System.Console.WriteLine(" a == c is " + (a == c)); 
		System.Console.WriteLine(" a <= c is " + (a <= c));
		System.Console.WriteLine(" a >= b is " + (a >= b)); 
		System.Console.WriteLine(" b != c is " + (b != c)); 
		System.Console.WriteLine(" b == a+c is " + (b == a+c)); 
    }
}

class RelationalOperatorsCient
{
    public static void Main(string[] args)
    {
        RelationalOperators obj = new RelationalOperators();
        
        System.Console.Write("Enter number a: ");
		float a = float.Parse(System.Console.ReadLine());
        System.Console.Write("Enter number b: ");
        float b = float.Parse(System.Console.ReadLine());
		System.Console.Write("Enter number c: ");
        float c = float.Parse(System.Console.ReadLine());
        obj.SetVal(a,b,c);
    }
}


/*

Output:

Enter number a: 15
Enter number b: 20.75
Enter number c: 15
 a = 15
 b = 20.75
 c = 15
 a < b is True
 a > b is False
 a == c is True
 a <= c is True
 a >= b is False
 b != c is True
 b == a+c is False

*/

