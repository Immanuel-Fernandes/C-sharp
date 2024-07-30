class IncrementOperators
{
    private float m,n; 

    public void SetVal(float n1, float n2)
    {
        m=n1;
    	n=n2;
    	Display();
    }

    private void Display()
    {
        System.Console.WriteLine(" m = "+ m); 
    	System.Console.WriteLine(" n = "+ n); 

    	System.Console.WriteLine(" ++m = " + (++m));
    	System.Console.WriteLine(" n++ = " + (n++)); 

    	System.Console.WriteLine(" m = "+ m); 
    	System.Console.WriteLine(" n = "+ n); 
    }
}

class IncrementOperatorsCient
{
    public static void Main(string[] args)
    {
        IncrementOperators obj = new IncrementOperators();
        
        System.Console.Write("Enter number m: ");
	    float m = float.Parse(System.Console.ReadLine());
        System.Console.Write("Enter number n: ");
        float n = float.Parse(System.Console.ReadLine());

        obj.SetVal(m,n);
    }
}


/*

Output:

Enter number m: 10
Enter number n: 20
 m = 10
 n = 20
 ++m = 11
 n++ = 20
 m = 11
 n = 21

*/

