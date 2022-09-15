// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string[] cibiPreferiti = { "sushi", "pizza", "carbonara", "tagliata", "pesce" };

Console.WriteLine(cibiPreferiti.Length);

for (int i = 0; i < cibiPreferiti.Length; i++ )
{
    Console.WriteLine(cibiPreferiti[i]);
};

Console.WriteLine(cibiPreferiti.First());

Console.WriteLine(cibiPreferiti.Last());

int ciboMiddle = cibiPreferiti.Length / 2;

Console.WriteLine(cibiPreferiti[ciboMiddle]);