class BusLogic
{
    private char ch;
    private string result;

    public void SetVal(char l)
    {
        ch = l;
        Vowel();
    }

    private void Vowel()
    {
        if (ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'||ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
        {
            result = ch + " is a Vowel";
        }
        else
        {
            result = ch + " is a Consonant";
        }
    }

    public string Display()
    {
        return result;
    }
}

class CheckVowel
{
    public static void Main(string[] args)
    {
        BusLogic obj = new BusLogic();
        char ch = char.Parse(args[0]);
        obj.SetVal(ch);
        System.Console.WriteLine(obj.Display());
    }
}


/* 

Output: 

CheckVowel A
A is a Vowel

*/
