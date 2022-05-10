Console.WriteLine("Введите: <государство> <столица>");
var input = Console.ReadLine(); 
var splitted = input.Split(' ');    

Console.WriteLine($"Столица государства {splitted[0]} - город {splitted[1]}");
Console.WriteLine(String.Format("Столица государства {0} - город {1}",splitted[0], splitted[1]));

