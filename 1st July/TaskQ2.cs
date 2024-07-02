/* 

Question:

Write a C# program to Define 2 variables of float datatype Assign 75.86 to x and 43.48 to y and store the sum in integer m with method

*/

class TaskQ2
{
    static void Main()
    {
        float x = 75.86f;
        float y = 43.48f;

        int m = Sum(x, y);

        System.Console.WriteLine("Sum of {0} and {1} is: {2}",x,y,m);
    }

    static int Sum(float a, float b)
    {
        float m = a + b;
        return (int)m; 
    }
}




/* 

Output: 

Sum of 75.86 and 43.48 is: 119

*/