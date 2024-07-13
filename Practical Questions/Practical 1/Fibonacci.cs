public class BusLogic
{
    private int Term;
    private string FibSeq;

    public void SetValuesAndProcess(int num)
    {
        Term = num;
        Fibonacci();
    }

    private void Fibonacci()
    {
        int a = 0, b = 1, c, i = 3;
        FibSeq = a + "\t" + b;

        while (i <= Term)
        {
            c = a + b;
            FibSeq += "\t" + c;
            a = b;
            b = c;
            i++;
        }
    }

    public string GetFibSeq()
    {
        return FibSeq;
    }
}


public class Fibonacci
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();

        System.Console.Write("Enter number of Digits: ");
        int a = System.Convert.ToInt32(System.Console.ReadLine());

        obj.SetValuesAndProcess(a);

        System.Console.Write("Fibonacci sequence: ");
        System.Console.WriteLine(obj.GetFibSeq());
    }
}


/* 

Output: 

Enter number of Digits: 5
Fibonacci sequence: 0   1       1       2       3

*/
