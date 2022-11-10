using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace ProcessingStringNamespace;
public class ProcessingString
{
    public static bool CanCreate(string? s1, string? s2)
    {
        if (s1 == null || s2 == null)
            return false;
        char[] copies = new char[s1.Length];
        int[] counters = new int[s1.Length];
        int k = 0, arrInd;
        for (int i = 0; i < s1.Length; i++)
        {
            arrInd = Array.IndexOf(copies, s1[i]);
            if (arrInd == -1)
            {
                copies[k] = s1[i];
                counters[k]++;
                k++;
            }
            else
            {
                counters[arrInd]++;
            }

        }

        for (int i = 0; i < s2.Length; i++)
        {
            arrInd = Array.IndexOf(copies, s2[i]);
            if (arrInd == -1)
            {
                return false;
            }
            else if(counters[arrInd] <= 0)
            {
                return false;
            }
            else
            {
                counters[arrInd]--;
            }
        }
        return true;
    }

    public static string SumOfNumbersInString(String str)
    {
        Regex rx = new Regex(@"\d+");
        int sum = 0;
        MatchCollection mtchCllctn = rx.Matches(str);
        foreach (Match digit in mtchCllctn)
        {
            sum += Convert.ToInt32(digit.Value);
        }
        return "sum of numbers = " + sum;
    }
}

