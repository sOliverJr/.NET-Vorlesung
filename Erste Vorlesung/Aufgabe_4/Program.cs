Console.Write("Zahl 1:");
string string1 = Console.ReadLine();
Console.Write("Zahl 2:");
string string2 = Console.ReadLine();
Console.Write("Operator:");
string op = Console.ReadLine();

int zahl1 = Int16.Parse(string1);
int zahl2 = Int16.Parse(string2);

Console.Write("Ergebnis: ");
if (op == "*")
{
    Console.WriteLine(zahl1 * zahl2);
}
else if (op == "+")
{
    Console.WriteLine(zahl1 + zahl2);
}
else if (op == "-")
{
    Console.WriteLine(zahl1 - zahl2);
}
Console.ReadLine();