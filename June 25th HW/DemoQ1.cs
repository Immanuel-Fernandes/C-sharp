/* 

Question:

Write a Csharp program to define 2 strings outside the main function without using static use formatisers and display it

*/

class DemoQ1
{
    string str1 = "Hello";
    string str2 = "World";

    static void Main(string[] args)
    {
        DemoQ1 obj = new DemoQ1();
        System.Console.WriteLine("{0} {1}", obj.str1,obj.str2);
    }
}


/* 

Output: 

Hello World

*/