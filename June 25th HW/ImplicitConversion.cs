/* 

Question:

Write a C# program to perform Implicitly conversion

*/

class ImplicitConversion
{
    public static void Main(string[] args)
    {
        byte byteValue = 100;        
        int intValue = byteValue; // Implicitly conversion

        System.Console.WriteLine("Byte value: " + byteValue);
        System.Console.WriteLine("Int value: " + intValue);
    }
}

/* 

Output: 

Byte value: 100
Int value: 100

*/
