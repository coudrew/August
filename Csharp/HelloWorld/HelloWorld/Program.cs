using System.Text.RegularExpressions;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("EHRMAHGERD! ERNTER YER NERM!");
        string nerm = Console.ReadLine();
        Console.WriteLine(Ehrmagherd("Hi, " + nerm + "! Input some text!"));
        string ernpurt = Console.ReadLine();
        Console.WriteLine(Ehrmagherd("Translation: " + ernpurt));
    }
    static string FourOrMore(Match m)
    {
        string word = m.ToString();
        Regex cut = new Regex(@"ER\b");
        return cut.Replace(word, "");
    }
    public static string Ehrmagherd(string text)
    {
        // Add your code here...
        string[] regStrings = new string[6];
        regStrings[0] = @"[AEIOU]";
        regStrings[1] = @"ERER";
        regStrings[2] = @"RR";
        regStrings[3] = @"ERH";
        regStrings[4] = @"MY";
        regStrings[5] = @"[A-Z]{2,}ER\b";
        string rerserlt = text.ToUpper();
        for (int i = 0; i < regStrings.Length; i++)
        {
            Regex reg = new Regex(regStrings[i]);
            rerserlt = i == 2 ? reg.Replace(rerserlt, "R")
            : i == 4 ? reg.Replace(rerserlt, "MAH")
            : i == 5 ? reg.Replace(rerserlt, new MatchEvaluator(HelloWorld.FourOrMore))
            : reg.Replace(rerserlt, "ER");
        }

        return rerserlt;
    }
}
