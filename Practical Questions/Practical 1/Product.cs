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

public class Product
{
    public static void Main(string[] args)
    {
        int a, b, c, d;

        System.Console.Write("Enter number a: ");
        a = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter number b: ");
        b = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter number c: ");
        c = System.Convert.ToInt32(System.Console.ReadLine());
        System.Console.Write("Enter number d: ");
        d = System.Convert.ToInt32(System.Console.ReadLine());

        BusLogic obj = new BusLogic();
        System.Console.WriteLine("The product of the numbers is: {0}",obj.SetValue(a, b, c, d));
    }
}

