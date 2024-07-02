/* 

Question:

Write a Csharp program to define 2 strings outside the main function without using static keyword and display the second string first

*/

class DemoQ2
{
    string str1 = "Immanuel";
    string str2 = "Hello";

    static void Main(string[] args)
    {
        DemoQ2 obj = new DemoQ2();
        System.Console.WriteLine("{1} {0}", obj.str1,obj.str2);
    }
}


/* 

Output: 

Hello Immanuel

*/