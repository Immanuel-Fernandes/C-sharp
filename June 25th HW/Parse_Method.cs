/* 

Question:

Write a C# program to perform conversion using Parse Method

*/

class Parse_Method
{
    public static void Main(string[] args)
    {
        string str1 = "65";
        string str2 = "123.45";

        int ival = int.Parse(str1);
        double dVal = double.Parse(str2);

        System.Console.WriteLine("String value: {0}, {1}", str1, str2);
        System.Console.WriteLine("Int value after parsing from string: " + ival);
        System.Console.WriteLine("Double value after parsing from string: " + dVal);

    }
}

/* 

Output: 

String value: 65, 123.45
Int value after parsing from string: 65
Double value after parsing from string: 123.45

*/
