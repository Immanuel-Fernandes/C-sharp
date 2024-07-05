/* 

Question:

For a certain electrical Circuit to the inductance N and resistance R the ____ natural frequency given by 
frequency=sqrt((1/lc)-(r^2/4c^2)). The Result to study the variation of frequency with C(capacitors).
Write a C# program to calculate the frequency for the different values of C starting from 0.01 to 0.1 in steps of 0.01

*/

class Task7
{
    static float CalculateFrequency(float L, float R, float C, float startC, float endC, float stepC)
    {
        if (startC > endC)
        {
            return 0; 
        }
        else
        {
            // float term1 = 1.0f / (L * startC);
            // float term2 = R * R / (4.0f * startC * startC);
            // double frequency = System.Math.Sqrt(term1 - term2);

            double frequency = System.Math.Sqrt((1 / (L * startC)) - (R * R / (4 * startC * startC)));

            string f =frequency.ToString();;

            System.Console.WriteLine("For C = {0}, Frequency = {1:F2}",startC,f);

            // Recursive call 
            return CalculateFrequency(L, R, C, startC + stepC, endC, stepC);
        }
    }

    static void Main(string[] args)
    {
        System.Console.Write("Inductance:");
        string Inductance = System.Console.ReadLine();
        float L = float.Parse(Inductance);

        System.Console.Write("Resistance:");
        string Resistance = System.Console.ReadLine();
        float R =  float.Parse(Resistance);

        float startC = 0.01f;
        float endC = 0.1f;
        float stepC = 0.01f;

        CalculateFrequency(L, R, startC, startC, endC, stepC);
        
    }
}



/* 

Output: 

Inductance:0.8
Resistance:1.5
For C = 0.01, Frequency = NaN
For C = 0.02, Frequency = NaN
For C = 0.03, Frequency = NaN
For C = 0.04, Frequency = NaN
For C = 0.05, Frequency = NaN
For C = 0.05999999, Frequency = NaN
For C = 0.06999999, Frequency = NaN
For C = 0.07999999, Frequency = NaN
For C = 0.08999999, Frequency = NaN
For C = 0.09999999, Frequency = NaN

*/