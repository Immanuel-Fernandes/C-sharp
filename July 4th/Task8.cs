class Task8
{
    static double CalculateFrequency(double L, double R, double startC, double endC, double stepC)
    {
        if (startC > endC)
        {
            return 0;
        }
        else
        {
            double term1 = 1.0 / (L * startC);
            double term2 = (R * R) / (4.0 * startC * startC);
            double frequency = System.Math.Sqrt(term1 - term2);

            System.Console.WriteLine("For C = {0:F2}, Frequency = {1:F2}", startC, frequency);

            return CalculateFrequency(L, R, startC + stepC, endC, stepC);
        }
    }

    static void Main(string[] args)
    {
        System.Console.Write("Inductance: ");
        string Inductance = System.Console.ReadLine();
        double L = double.Parse(Inductance);

        System.Console.Write("Resistance: ");
        string Resistance = System.Console.ReadLine();
        double R = double.Parse(Resistance);

        double startC = 0.01;
        double endC = 0.1;
        double stepC = 0.01;

        CalculateFrequency(L, R, startC, endC, stepC);
    }
}
