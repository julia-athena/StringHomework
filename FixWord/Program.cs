using System;

var input = "рпроцессо";


var chars = input.ToCharArray();    
for (int i = 0; i < chars.Length-1; i++)
{
    (chars[i], chars[i+1]) = (chars[i+1], chars[i]);
}

var res = new string(chars);
Console.WriteLine(res);
