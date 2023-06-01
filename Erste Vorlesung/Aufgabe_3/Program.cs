// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hallo, gib einen Satz ein!");

string input = Console.ReadLine();

char[] charArray = input.ToCharArray();

for (int i = charArray.Length; i > 0; i--)
{
    Console.Write(charArray[i-1]);
}
Console.WriteLine("");
Console.WriteLine("Done!");
Console.ReadLine();
