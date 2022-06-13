using System;
using System.Globalization;
using System.Linq;
using System.Text;

var word = "émotion";

ReverseChars(word);
ReverseTextElements(word);
GetCharByIndex(word,1);
GetTextElementByIndex(word,1);
AreEqualChars(word,2,5);
ConcatChars(word, 2, 3);
ChangeSymbols("пуансеттия",2);
CountDiffLetters(word);
CountNearLetters(word);
GetHalf(word);
ChangeHalves(word);
ChangeFirstLastLetters(word,2);
IsPalindrom("мадам");

static string ReverseChars(string input)
{
    Console.WriteLine("Слово наоборот");
   
    var chars = input.Reverse().ToArray();
    var result = new string(chars);
    
    Console.WriteLine(result);
    return result;
}
static string ReverseTextElements(string input)
{
    Console.WriteLine("Слово наоборот (c учетом составных символов)");
    
    var symbols = StringInfo.ParseCombiningCharacters(input);
    var builder = new StringBuilder();
    var reversed = symbols.Reverse();
    foreach (var i in reversed)
    {
        builder.Append(StringInfo.GetNextTextElement(input, i));
    }
    var result = builder.ToString();
    
    Console.WriteLine(result);
    return result;
}

static char GetCharByIndex(string input, int i)
{
    Console.WriteLine($"{i}-й символ");
    
    var result = input[i];
    
    Console.WriteLine(result);
    return result;
}
static string GetTextElementByIndex(string input, int i)
{
    Console.WriteLine($"{i}-й символ (с учетом составных символов)");
    
    var result = StringInfo.GetNextTextElement(input, i);
    
    Console.WriteLine(result);
    return result;
}
static bool AreEqualChars(string input, int i, int j)
{
    Console.WriteLine($"Одинаковы ли {i}-й и {j}-й символы");
    
    var result = input[i] == input[j]; 
    
    Console.WriteLine(result);
    return result;
}
static string ConcatChars(string input, int i, int j)
{
    Console.WriteLine($"Буквосочетание, состоящее из {i} и {j} символов");
    
    var result = "" + input[i] + input[j];
    
    Console.WriteLine(result);
    return result;
}
//todo
static string ChangeSymbols(string input, int x)
{
    Console.WriteLine($"Поменять местами буквы, номера которых вычисляются как степень {x}");
    var builder = new StringBuilder(input);
    var prevIndex = (int) Math.Pow(x, 0)-1;
    for (int i = 1; i < (int)Math.Log(input.Length,x); i++)
    {
        var currIndex = (int) Math.Pow(x, i)-1;
        (builder[prevIndex], builder[currIndex]) = (builder[currIndex], builder[prevIndex]);
        prevIndex = currIndex;
    }
    var result = builder.ToString();
    Console.WriteLine(result);
    return result;
}
static int CountDiffLetters(string input)
{
    Console.WriteLine("Сколько различных букв в слове");
    
    var result = input.ToUpperInvariant().Distinct().Count();

    Console.WriteLine(result);
    return result;
}

static int CountNearLetters(string input)
{
    Console.WriteLine("Сколько одинаковых соседних букв");
    var result = 0;
    for (int i = 0; i < input.Length-1; i++)
    {
        if (input[i] == input[i + 1]) result++;
    }

    Console.WriteLine(result);
    return result;
}
static string GetHalf(string input)
{
    Console.WriteLine("Вывести на экран первую половину слова");
    
    var endIndex = input.Length / 2;
    var result = input[0..endIndex]; //шок контент
    
    Console.WriteLine(result);
    return result;
}
static string ChangeHalves(string input)
{
    Console.WriteLine("поменять местами половины слова");
    
    var index = input.Length / 2;
    var result = input[^index..] + input[..index]; //шок контент 2

    Console.WriteLine(result);
    return result;
}
static string ChangeFirstLastLetters(string input, int x)
{
    Console.WriteLine($"переставить первые {x} и последние {x} буквы, сохранив порядок их следования");
    
    var result = input[^x..] + input[x..^x] + input[..x]; //сверхразум
    
    Console.WriteLine(result);
    return result;
}

static bool IsPalindrom(string input)
{
    Console.WriteLine("проверить, является ли слово перевертышем");
    var result = true;
    for (int i = 0,j = input.Length-1; i < input.Length/2; i++,j--)
    {
        if (input[i] != input[j])
        {
            result = false;
            break;
        }
    }
    
    
    Console.WriteLine(result);
    return result;
}
