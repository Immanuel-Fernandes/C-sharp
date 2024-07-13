public class BusLogic
{
    private int a,b,c,d,product;

    public int SetValue(int n1, int n2, int n3, int n4)
    {
        a = n1;
        b = n2;
        c = n3;
        d = n4;
        product = Cal();
        return product;
    }

    private int Cal()
    {
        return a * b * c * d;
    }
}

public class Product1
{
    public static void Main(string[] args)
    {
        int a, b, c, d;

        a = int.Parse(args[0]);
        b = int.Parse(args[1]);
        c = int.Parse(args[2]);
        d = int.Parse(args[3]);

        BusLogic obj = new BusLogic();
        System.Console.WriteLine("The product of the numbers is: {0}",obj.SetValue(a, b, c, d));
    }
}


/* 

Output: 

Product1.exe 10 20 30 40
The product of the numbers is: 240000

*/
