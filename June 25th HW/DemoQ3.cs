/* 

Question:

Write a c sharp program to define all the datatypes in C# and display min value, max value, Specify Signed and unsigned use (IsPositive, IsNegative Function) without usimg Conditional Statements

*/

class DemoQ3
{
    static void Main(string[] args)
    {
        // Define data types
        // byte a = 1;
        // sbyte b = 2;
        short c = 3;
        // ushort d = 4;
        int e = -5;
        // uint f = 6;
        // long g = 7;
        // ulong h = 8;
        // float i = 9.0f;
        double j = -3.0;
        // decimal k = 10.0m;

        System.Console.WriteLine("byte Min Value:{0} Max Value:{1}", byte.MinValue, byte.MaxValue);
        System.Console.WriteLine("sbyte Min Value:{0} Max Value:{1}", sbyte.MinValue, sbyte.MaxValue);
        System.Console.WriteLine("short Min Value:{0} Max Value:{1}", short.MinValue, short.MaxValue);
        System.Console.WriteLine("ushort Min Value:{0} Max Value:{1}", ushort.MinValue, ushort.MaxValue);
        System.Console.WriteLine("int Min Value:{0} Max Value:{1}", int.MinValue, int.MaxValue);
        System.Console.WriteLine("uint Min Value:{0} Max Value:{1}", uint.MinValue, uint.MaxValue);
        System.Console.WriteLine("long Min Value:{0} Max Value:{1}", long.MinValue, long.MaxValue);
        System.Console.WriteLine("ulong Min Value:{0} Max Value:{1}", ulong.MinValue, ulong.MaxValue);
        System.Console.WriteLine("float Min Value:{0} Max Value:{1}", float.MinValue, float.MaxValue);
        System.Console.WriteLine("double Min Value:{0} Max Value:{1}", double.MinValue, double.MaxValue);
        System.Console.WriteLine("decimal Min Value:{0} Max Value:{1}", decimal.MinValue, decimal.MaxValue);

        System.Console.WriteLine("Is {0} negative? {1}", e, System.IsNegative(e));
        System.Console.WriteLine("Is {0} negative? {1}", c, System.IsNegative(c));
        System.Console.WriteLine("Is {0} negative? {1}", j, System.IsNegative(j));
    }

    // static bool IsNegative(int number)
    // {
    //     return System.Math.Sign(number) < 0;
    // }

    // static bool IsNegative(short number)
    // {
    //     return System.Math.Sign(number) < 0;
    // }

    // static bool IsNegative(double number)
    // {
    //     return System.Math.Sign(number) < 0;
    // }

}


/* 

Output: 

byte Min Value:0 Max Value:255
sbyte Min Value:-128 Max Value:127
short Min Value:-32768 Max Value:32767
ushort Min Value:0 Max Value:65535
int Min Value:-2147483648 Max Value:2147483647
uint Min Value:0 Max Value:4294967295
long Min Value:-9223372036854775808 Max Value:9223372036854775807
ulong Min Value:0 Max Value:18446744073709551615
float Min Value:-3.402823E+38 Max Value:3.402823E+38
double Min Value:-1.79769313486232E+308 Max Value:1.79769313486232E+308
decimal Min Value:-79228162514264337593543950335 Max Value:79228162514264337593543950335
Is -5 negative? True
Is 3 negative? False
Is -3 negative? True

*/