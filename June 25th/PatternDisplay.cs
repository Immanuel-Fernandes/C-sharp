class PatternDisplay
{
    public static void Main(string[] args)
    {
        string line1 = "   X   ";
        string line2 = "  XXX  ";
        string line3 = " XXXXX ";
        

        System.Console.WriteLine("{0}\n{1}\n{2}\n{1}\n{0}", line1, line2, line3);
    }
}