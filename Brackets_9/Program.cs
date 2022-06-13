
using System;

var text = "(()(()))";
CheckBrackets(text);


static void CheckBrackets(string text)
{
    Console.WriteLine("Правильно ли расставлены круглые скобки");
    var counter = 0;
    var wrongIndex = -1;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == '(')
            counter++;
        if (text[i] == ')')
            counter--;
        if (counter < 0)
        {
            wrongIndex = i;
            break;
        }
    }
    wrongIndex = counter > 0 ? text.Length : wrongIndex + 1;
    var print = wrongIndex == 0 ? "Да" : $"Нет. Неправильная позиция: {wrongIndex}";
    Console.WriteLine(print);
}
