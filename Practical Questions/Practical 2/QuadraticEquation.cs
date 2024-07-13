class BusLogic
{
    private double a,b,c;
    private string roots;

    public void SetCoefficients(double CoA, double CoB, double CoC)
    {
        a = CoA;
        b = CoB;
        c = CoC;
        CalculateRoots();
    }

    private void CalculateRoots()
    {
        double d = b * b - 4 * a * c;
        double sqrtD = System.Math.Sqrt(System.Math.Abs(d));

        if (d > 0)
        {
            double r1 = (-b + sqrtD) / (2 * a);
            double r2 = (-b - sqrtD) / (2 * a);
            roots = "Roots are real and different:\nRoot1 = "+r1+"\nRoot2 = "+r2;
        }
        else if (d == 0)
        {
            double r = -b / (2 * a);
            roots = "Roots are real and same:\nRoot = "+r;
        }
        else
        {
            double realPart = -b / (2 * a);
            double imagPart = sqrtD / (2 * a);
            roots = "Roots are complex:\nRoot1 = " + realPart +" + "+ imagPart+"i\nRoot2 = "+realPart+" - "+imagPart+"i";
        }
    }

    public string Display()
    {
        return roots;
    }
}

class QuadraticEquation
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();

        System.Console.Write("Enter coefficient a: ");
        double a = double.Parse(System.Console.ReadLine());
        System.Console.Write("Enter coefficient b: ");
        double b = double.Parse(System.Console.ReadLine());
        System.Console.Write("Enter coefficient c: ");
        double c = double.Parse(System.Console.ReadLine());

        obj.SetCoefficients(a, b, c);
        System.Console.WriteLine(obj.Display());
    }
}

/* 

Output: 

Enter coefficient a: 1
Enter coefficient b: -3
Enter coefficient c: 2
Roots are real and different:
Root1 = 2
Root2 = 1

*/