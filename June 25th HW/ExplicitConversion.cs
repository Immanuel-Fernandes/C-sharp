/* 

Question:

Write a C# program to perform Explicitly conversion

*/

class ExplicitConversion
{
    public static void Main(string[] args)
    {
        float a = 78.2f;
        int b = (int)a; // Explicitly conversion

        System.Console.WriteLine("Float value: " + a);
        System.Console.WriteLine("Int value (after explicit conversion): " + b);
    }
}

/* 

Output: 

Float value: 78.2
Int value (after explicit conversion): 78

*/
