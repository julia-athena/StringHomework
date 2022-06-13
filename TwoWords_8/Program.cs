
using System;
using System.Linq;

var word1 = "привет";
var word2 = "при";
CanGetFrom(word1, word2);
PrintEqualLetters(word1, word2);


static bool CanGetFrom(string wordFrom, string wordTo)
{
    Console.WriteLine("можно ли из букв первого слова получить второе");
    
    var exceptList = wordTo.Except(wordFrom).ToList(); //исключаем из второго слова все символы кот есть в первом
    var result = exceptList.Count == 0 ? true : false;
    
    Console.WriteLine(result);
    return result;
}

static void PrintEqualLetters(string word1, string word2)
{
    Console.WriteLine("Пересекающиеся (повторяющиеся) буквы");
    var result = word1.ToUpperInvariant().Intersect(word2.ToUpperInvariant());
    Console.WriteLine(string.Join(" ", result));
}