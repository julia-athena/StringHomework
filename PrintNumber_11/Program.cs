
using System;
using System.Text;

var result = NumberToText("605");
Console.WriteLine(result);

static string NumberToText(string number)
{
    var order = number.Length; 
    var result = new StringBuilder();
    while(order > 0)
    {
        if (order == 2 && number[^order] == '1')
        {
            result.AppendFormat("{0} ", GetWordForDigit(number[^order], order, number[^(order-1)]));
            break;
        }
        result.AppendFormat("{0} ",GetWordForDigit(number[^order], order));
        order--;
    }
    return result.ToString();
}

static string GetWordForDigit(char digit, int order, char subdigit = char.MinValue)
{
    var result = string.Empty;
    if (order == 4)
    {
        if (digit == '1') result = "тысяча";
    }
    else if (order == 3)
    {
        if (digit == '1') result = "сто";
        else if (digit == '2') result = "двести";
        else if (digit == '3') result = "триста";
        else if (digit == '4') result = "четыреста";
        else if (digit == '5') result = "пятьсот";
        else if (digit == '6') result = "шестьсот";
        else if (digit == '7') result = "семьсот";
        else if (digit == '8') result = "восемьсот";
        else if (digit == '9') result = "девятьсот";
    }
    else if (order == 2)
    {
        if (digit == '1')
        {
            if (subdigit == '0') result = "десять";
            else if (subdigit == '1') result = "одиннадцать";
            else if (subdigit == '2') result = "двенадцать";
            else if (subdigit == '3') result = "тринадцать";
            else if (subdigit == '4') result = "четырнадцать";
            else if (subdigit == '5') result = "пятнадцать";
            else if (subdigit == '6') result = "шестнадцать";
            else if (subdigit == '7') result = "семнадцать";
            else if (subdigit == '8') result = "восемнадцать";
            else if (subdigit == '9') result = "девятнадцать";
        }
        else if (digit == '2') result = "двадцать";
        else if (digit == '3') result = "тридцать";
        else if (digit == '4') result = "сорок";
        else if (digit == '5') result = "пятьдесят";
        else if (digit == '6') result = "шестьдесят";
        else if (digit == '7') result = "семьдесят";
        else if (digit == '8') result = "восеьмдесят";
        else if (digit == '9') result = "девяносто";
    }
    else if (order == 1)
    {
        if (digit == '1') result = "один";
        else if (digit == '2') result = "два";
        else if (digit == '3') result = "три";
        else if (digit == '4') result = "четыре";
        else if (digit == '5') result = "пять";
        else if (digit == '6') result = "шесть";
        else if (digit == '7') result = "семь";
        else if (digit == '8') result = "восемь";
        else if (digit == '9') result = "девять";
    }

    return result;
}