using System;
using System.Linq;

var text = "приветики123 444вдпд555555гккрр8hhhhhhhhhhhh9";
PrintNumbers(text);
CountNumbers(text);
GetOrderNumMaxDigit(text);
CountMaxDigitCombination(text);
CountMaxEqualSymbolsCombination(text);

static void PrintNumbers(string text)
{
    Console.WriteLine("Все имеющиеся цифры");
    var numbers = text.Where(x => char.IsDigit(x));
    var result = string.Join(" ", numbers);
    Console.WriteLine(result);
}
static int CountNumbers(string text)
{
    Console.WriteLine("Количество цифр");
    var count = text.Count(ch => ch >= '0' && ch <= '9');
    Console.WriteLine(count);
    return count;
}
static int GetOrderNumMaxDigit(string text)
{
    Console.WriteLine("Порядковый номер максимальной цифры");
    var max = -1;
    var index = -1;
    for (int i = 0; i < text.Length; i++)
    {
        var numeric = (int)char.GetNumericValue(text, i);
        if (numeric > 0 && numeric > max)
        {
            max = numeric;
            index = i + 1;
        }
    }
    Console.WriteLine(index > 0 ? index : "Нет цифр");
    return index;
}
static int CountMaxDigitCombination(string text)
{
    Console.WriteLine("Наибольшее количество идущих подряд цифр");
    var count = 0;
    var max = 0;
    for(int i = 0; i < text.Length; i++)
    {
        if (text[i] >= '0' && text[i] <= '9')
            count++;
        else
        {
            max = count > max ? count : max;
            count = 0;
        }
    }
    Console.WriteLine(max);
    return max;
}
static int CountMaxEqualSymbolsCombination(string text)
{
    Console.WriteLine("Наибольшее количество идущих подряд одинаковых символов");
    var count = 0;
    var max = 0;
    var currChar = text[0];
    for(int i = 0; i < text.Length; i++)
    {
        if (text[i].Equals(currChar))
        {
            count++;
        }
        else
        {
            max = count > max ? count : max;
            count = 1;
            currChar = text[i];
        }
    }
    Console.WriteLine(max);
    return max;
}
