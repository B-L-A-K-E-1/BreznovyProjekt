
string cislo = Console.ReadLine();
int a = Convert.ToInt32(cislo);


string cislo2 = Console.ReadLine();
int b = Convert.ToInt32(cislo2);

if (a > b)
{
    Console.WriteLine(cislo);
    Console.WriteLine(cislo2);
}
else
{
    Console.WriteLine(cislo2);
    Console.WriteLine(cislo);
}
