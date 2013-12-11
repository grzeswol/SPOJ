/*
//int testCases = Int32.Parse(Console.ReadLine());

//    for (int i = 0; i < testCases; i++)
//    {
//        string line = Console.ReadLine();
//        string[] lines = line.Split(' ');
//        int[] ints = new int[lines.Length];

//        for (int z = 0; z < ints.Length; z++)
//        {
//            ints[z] = Convert.ToInt32(lines[z]);
//        }

//        int totalWeight = ints[0] * ints[2];
//        string final = (totalWeight <= ints[1]) ? "yes" : "no";
//        Console.WriteLine(final);
//    }
 * 
 * 
 * ////////////////////////////////////////////////kabala//////////////////////
 * SetDict();

    string s;
    try
    {
        while ((s = Console.ReadLine().Trim().ToLower()) != null)
        {
            char[] chars = s.ToCharArray();
            int final = 0;

            foreach (char c in chars)
            {
                final += dictionary[c.ToString()];
            }

            Console.WriteLine(final.ToString());
        }
    }
    catch (Exception ex)
    {
        return;
    }
}

static void SetDict()
{
    dictionary.Add("a", 1);
    dictionary.Add("b", 2);
    dictionary.Add("c", 3);
    dictionary.Add("d", 4);
    dictionary.Add("e", 5);
    dictionary.Add("f", 6);
    dictionary.Add("g", 7);
    dictionary.Add("h", 8);
    dictionary.Add("i", 9);
    dictionary.Add("k", 10);
    dictionary.Add("l", 20);
    dictionary.Add("m", 30);
    dictionary.Add("n", 40);
    dictionary.Add("o", 50);
    dictionary.Add("p", 60);
    dictionary.Add("q", 70);
    dictionary.Add("r", 80);
    dictionary.Add("s", 90);
    dictionary.Add("t", 100);
    dictionary.Add("v", 200);
    dictionary.Add("x", 300);
    dictionary.Add("y", 400);
    dictionary.Add("z", 500);
}
 * 
 * ////////////////////////////////////////////////////////////////
 * string line = Console.ReadLine();
        string final = line.Substring(0, (line.Length / 2));
        Console.WriteLine(final);
 * /////////////////////////////////////////////////////////////////////CAESAR///////////////
 * static string Cypher(string s)
{
            
    List<char> alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
    StringBuilder result = new StringBuilder();

    foreach (char c in s)
    {
        int temp = alpha.IndexOf(c);

        if (c == ' ')
        {
            result.Append(' ');
        }
        else if ((temp + 3) <= alpha.Count)
        {
            result.Append(alpha[temp + 3]);
        }
        else
        {
            result.Append(alpha[(temp + 3) - alpha.Count]);
        }
    }
    return result.ToString();
}
 * //////////////////////////////////////////////////
 *
 *  int testCases = Int32.Parse(Console.ReadLine());

    for (int i = 0; i < testCases; i++)
    {
        var firstLine = Console.ReadLine().Split(' ');
        double capacity = Int32.Parse(firstLine[1]);
        var secondLine = Console.ReadLine().Split(' ');
        double totalMass = secondLine.Sum(s => Int32.Parse(s));
        double temp = totalMass / capacity;

        double temp2 = Math.Ceiling(secondLine.Length/2.0);
        double final = Math.Ceiling(temp);

        if (temp2 > final )
        {
            final = temp2;
        }
        Console.WriteLine(final.ToString());
    }
 * 
 *
 *  private static string Mirrorize(string s)
{
    string binaryNumber = GetBinaryFromString(s);
    string reversed = ReverseString(binaryNumber);
    string final = GetStringFromBinary(reversed);
    return final;
}

static string GetBinaryFromString(string s)
{
    long number = long.Parse(s);
    return Convert.ToString(number, 2);
}

static string GetStringFromBinary(string s)
{
    long value = Convert.ToInt64(s, 2);
    return value.ToString();
}

static string ReverseString(string s)
{
    var temp = s.ToCharArray();
    Array.Reverse(temp);
    return new string(temp);
}
/////////////////////////////////////////////PRZEDSZK////////////////////////////////////////////////////
 * 
 * 
 * int testNumber = Convert.ToInt32(Console.ReadLine().Trim());

    for (int i = 0; i < testNumber; i++)
    {
        try
        {
            string line = Console.ReadLine().Trim();
            string[] lines = line.Split(' ');
            int numberA = Convert.ToInt32(lines[0]);
            int numberB = Convert.ToInt32(lines[1]);

            string result = LCM(numberA, numberB).ToString();
                    
            Console.WriteLine(result);
                   
        }
        catch (Exception)
        {
            return;
        }
                
     }
 * 
 * public static int GCD(int numberA, int numberB)
        {
            if (numberB == 0)
            {
                return numberA;
            }
            else
            {
                return GCD(numberB, numberA%numberB);
            }
        }

        public static int LCM(int numberA, int numberB)
        {
            return Math.Abs(numberA*numberB)/GCD(numberA, numberB);
        }
 * 
 * 
 ////////////////////////////////////////////////////////JROWLIN//////////////////////////////
 * using System;
using System.Globalization;

namespace spoj
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            try
            {
                while ((s = Console.ReadLine().Trim().ToLower()) != null)
                {
                    string[] lines = s.Split(' ');
                    double a = double.Parse(lines[0], CultureInfo.InvariantCulture);
                    double b = double.Parse(lines[1], CultureInfo.InvariantCulture);
                    double c = double.Parse(lines[2], CultureInfo.InvariantCulture);

                    string answer = Solve(a, b, c);
                    Console.WriteLine(answer);
                }
            }
            catch (Exception)
            {
                return;
            }
            
            
        }

        static string Solve(double a, double b, double c)
        {
            if (a == 0 && b == c)
            {
                return "NWR";
            }
            else if (a == 0)
            {
                return "BR";
            }
            else
            {
                b += -c;
                double temp = Math.Round(-b/a, 2);
                return temp.ToString("0.00", CultureInfo.InvariantCulture);
            }
        }
        
    }


}



///////////////////////////////////////////////////JSZYCER//////////////////////////////////////
 * private static List<char> _alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();

        static void Main(string[] args)
        {
            string s;
            try
            {
                while ((s = Console.ReadLine().Trim().ToLower()) != null)
                {
                    int shift = 3;
                    string answer = CaesarDecrypt(s,shift);
                    Console.WriteLine(answer);
                }
            }
            catch (Exception)
            {
                return;
            }

        }


        private static string CaesarDecrypt(string encryptedString, int shift)
        {
            StringBuilder sb = new StringBuilder();
            encryptedString = encryptedString.ToUpper().Trim();
            foreach (char c in encryptedString)
            {
                if (Char.IsLetter(c))
                {
                    int index = _alpha.IndexOf(c);
                    sb.Append(_alpha[(shift + index)%_alpha.Count]);
                }
                else
                {
                    sb.Append(c);
                }
                
            }

            return sb.ToString();
        }
 * 
 ////////////////////////////////////////////////////////////JSPACE/////////////////////////////////
 * static void Main(string[] args)
        {
            string s;
            try
            {
                while ((s = Console.ReadLine()) != null)
                {
                    int lower = (s[0] == ' ') ? 0 : 1;

                    var words = s.Trim().Split(' ');

                    for (int i = lower; i < words.Length; i++)
                    {
                        words[i] = Capitalize(words[i]);
                    }

                    string answer = String.Join("", words);
                    Console.WriteLine(answer);
                }
            }
            catch (Exception)
            {
                return;
            }

        }

        static string Capitalize(string word)
        {
            if (word.Length == 0)
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            string firstWord = word[0].ToString();
            sb.Append(firstWord.ToUpper() + word.Substring(1));
            return sb.ToString();
        }
 * 
 */
