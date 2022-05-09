var input = "рпроцессо";


var chars = input.ToCharArray();    
for (int i = 0; i < chars.Length-1; i++)
{
    var temp = chars[i];
    chars[i] = chars[i + 1];
    chars[i + 1] = temp;
}

var res = new string(chars);
Console.WriteLine(res);
