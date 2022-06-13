
using System;
using System.Text;

var input = "1 1 1";
var str = input.Trim();
AddSpaces(str, 78);

//todo
static string AddSpaces(string input, int length)
{
    var delta = length - input.Length;
    if (delta <= 0) 
        return input;
    
    var builder = new StringBuilder(input);
    var i = 0;
    while (delta > 0)
    {
        if (i == builder.Length) i = 0;
        if (builder[i] == ' ' && builder[i + 1] != ' ')
        {
            builder.Insert(i, ' ');
            delta--;
            while (builder[i] == ' ') i++; 
        }

        i++;
    }
    var result = builder.ToString();
    
    Console.WriteLine(result);
    return result;
}
