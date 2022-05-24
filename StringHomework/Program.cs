
using System;
using System.Collections.Generic;
using System.Text;

var input = "информатика";
var search = new List<string>() { "форма", "тик" };

foreach (var s in search)
{
    WithSubstring(input, s);
    WithConcat(input, s);
}

static void WithSubstring(string input, string search)
{
    var startIndex = input.IndexOf(search);
    var res = startIndex != -1 ? input.Substring(startIndex, search.Length) : String.Empty;
    Console.WriteLine($"WithSubstring {input}: {res}");
}
static void WithConcat(string input, string search)
{
    var builder = new StringBuilder();
    foreach(var s in search)
    {
        var index = input.IndexOf(s);
        if (index != -1)
            builder.Append(input[index]);
        else
        {
            builder.Clear();
            break;
        }
    }
    var res = builder.ToString();
    Console.WriteLine($"WithConcat {input}: {res}");
}
