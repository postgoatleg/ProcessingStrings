using System.Text;
using System.Text.RegularExpressions;
using ProcessingStringNamespace;
using static System.Net.Mime.MediaTypeNames;

//Console.WriteLine("Введите первое слово");
//string? a = Console.ReadLine();
//Console.WriteLine("Введите второе слово");
//string? b = Console.ReadLine();
////StringBuilder test = new StringBuilder("jrte43uu64te 95 12", 30);
////Console.WriteLine(ProcessingString.SumOfNumbersInString(test.ToString()));
//string ans = ProcessingString.CanCreate(a, b) == true ? "можно составить" : "нельзя составить";
//Console.WriteLine(ans);
////Console.WriteLine(test[0]);
//Console.WriteLine("Введите cтроку для суммирования цифр в ней");
//StringBuilder test = new StringBuilder(Console.ReadLine(), 50);
//Console.WriteLine(ProcessingString.SumOfNumbersInString(test.ToString()));


string test = "f(x)=cos(x)*sin(x)";
char[] charSeparators = new char[] { '=', '+', '-', '/', '*' };
string[] testArr = test.Split(charSeparators);
string[] strSeparators = new string[] {"1", "2", "3", "4," };

foreach(string el in testArr)
{
    Console.WriteLine(el);
}

Console.ReadLine();
