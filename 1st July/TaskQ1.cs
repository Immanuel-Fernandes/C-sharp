/* 

Question:

Write a C# program to Define 2 variables of float datatype Assign 75.86 to x and 43.48 to y aand store the sum in integer m without method

*/

class TaskQ1
{
    static void Main()
    {
        float x = 75.86f;
        float y = 43.48f;

        int m = (int)(x+y);

        System.Console.WriteLine("Sum of {0} and {1} is: {2}",x,y,m);
    }
}



/* 

Output: 

Sum of 75.86 and 43.48 is: 119

*/