
using System;
using System.Globalization;
using System.Linq;
using System.Text;

var sentence = "hallo amigos";
GetLetterPercent(sentence);
CountLetterCombinations(sentence);
CountWords(sentence);
ConcatFirstLetters(sentence);
CountVowelLetters(sentence);
Has5InRowSymbols(sentence);
ChangeSymbols(sentence);
Reverse(sentence);
ShowWordsInclude(sentence);

static float GetLetterPercent(string sentence)
{
    Console.WriteLine("Определяем долю (в %) букв Х");
    Console.Write("Введите букву: ");
    var letter = Console.ReadLine();
    var n = 0;
    var numerator = StringInfo.GetTextElementEnumerator(sentence);
    while(numerator.MoveNext())
    {
        if (numerator.GetTextElement() == letter) 
            n++;
    }
    var percent = ((float)n/sentence.Length)*100;

    Console.WriteLine(percent);
    return percent;
}
static int CountLetterCombinations(string sentence)
{
    Console.WriteLine("Определяем число вхождений буквосочетания");
    Console.Write("Введите буквосочетание: ");
    var value = Console.ReadLine();
    var count = 0;
    var index = sentence.IndexOf(value, 0, StringComparison.Ordinal); 
    while(index != -1)
    {
        count++;
        index = sentence.IndexOf(value, index+1, StringComparison.Ordinal);
    }

    Console.WriteLine(count);
    return count;
}

static int CountWords(string sentence)
{
    Console.WriteLine("количество слов в предложении");
    var splitted = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
    Console.WriteLine(splitted.Length);
    return splitted.Length;
}
static string ConcatFirstLetters(string sentence)
{
    Console.WriteLine("текст, составленный из первых букв всех слов");
    var builder = new StringBuilder();
    builder.Append(sentence[0]);
    for (int i = sentence.IndexOf(' ',0); i < sentence.Length; i++)
    {
        if (sentence[i] == ' ')
        {
            builder.Append(sentence[i + 1]);
        }
    }
    var result = builder.ToString();

    Console.WriteLine(result);
    return result;
}
static int CountVowelLetters(string sentence)
{
    Console.WriteLine("сколько гласных букв");
    var vowel = "ауоиэыяюеёaeiouy";
    var n = 0;
    foreach (var symbol in sentence)
    {
        if (char.IsLetter(symbol) && vowel.Contains(symbol, StringComparison.OrdinalIgnoreCase))
            n++;
    }

    Console.WriteLine(n);
    return n;
}
static bool Has5InRowSymbols(string sentence)
{
    Console.WriteLine("верно ли, что есть пять идущих подряд одинаковых символов");
    var count = 0;
    var result = false;
    for (int i = 0; i < sentence.Length-1; i++)
    {
        if (sentence[i] == sentence[i + 1])
            count++;
        else count = 0;
        if (count == 5)
        {
            result = true;
            break;
        }
    }

    Console.WriteLine(result);
    return result;
}

static string ChangeSymbols(string sentence)
{
    Console.WriteLine("символы, стоящие на третьем, шестом, девятом и т. д. местах, заменить буквой Х");
    Console.WriteLine("Введите букву: ");
    var input = Console.ReadLine();
    var symbol = input[0];
    var builder = new StringBuilder(sentence);
    for (int i = 2; i < sentence.Length/3; i=i+3)
    {
        builder.Replace(sentence[i], symbol, i, 1);
    }
    var result = builder.ToString();

    Console.WriteLine(result);
    return result;
}
static string Reverse(string sentence)
{
    Console.WriteLine("напечатать обратном порядке слова");
    var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var builder = new StringBuilder();
    builder.AppendJoin(' ', words.Reverse());
    var result = builder.ToString();

    Console.WriteLine(result);
    return result;
}
static void ShowWordsInclude(string sentence)
{
    Console.WriteLine("вывести все вхождения в предложение заданных слов");
    Console.WriteLine("Введите слова через пробел: "); 
    var words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var builder = new StringBuilder();
    foreach (var word in words)
    {
        if (sentence.IndexOf(word, StringComparison.OrdinalIgnoreCase) > 0)
        {
            builder.Append($"{word} ");
        }
    }
    var result = builder.ToString().TrimEnd();

    Console.WriteLine(result);
}