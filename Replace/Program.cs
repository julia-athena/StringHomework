
using System;

var input = "вирус";
var aim = "фокус";

if (input.Length != aim.Length)
{
    Console.WriteLine("Can not replace chars");
    return;
}

var chars = input.ToCharArray();
for (var i = 0; i < chars.Length; i++)
{
    chars[i] = aim[i];
}

var res = new string(chars);
Console.WriteLine(res);





