class FloatPoint
{
    private float a, b; 

    public void SetVal(float n1, float n2)
    {
        a=n1;
    	b=n2;
    	Display();
    }

    private void Display()
    {
        System.Console.WriteLine(" a = "+ a); 
    	System.Console.WriteLine(" b = "+ b); 
    	System.Console.WriteLine(" a + b = " + (a + b));

    	System.Console.WriteLine(" a - b = " + (a - b)); 
    	System.Console.WriteLine(" a * b = " + (a * b)); 
    	System.Console.WriteLine(" a / b = " + (a / b));
    	System.Console.WriteLine(" a % b = " + (a % b)); 
    }
}

class FloatPointCient
{
    public static void Main(string[] args)
    {
        FloatPoint obj = new FloatPoint();
        
        System.Console.Write("Enter number a: ");
	    float a = float.Parse(System.Console.ReadLine());
        System.Console.Write("Enter number b: ");
        float b = float.Parse(System.Console.ReadLine());
        obj.SetVal(a,b);
    }
}


/*

Output:

Enter number a: 20.5
Enter number b: 6.4
 a = 20.5
 b = 6.4
 a + b = 26.9
 a - b = 14.1
 a * b = 131.2
 a / b = 3.203125
 a % b = 1.3

*/

