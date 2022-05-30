Console.WriteLine("Zadejte první číslo");
string cislo = Console.ReadLine();
int a = Convert.ToInt32(cislo);

Console.WriteLine("Zadejte druhý číslo");
string cislo2 = Console.ReadLine();
int b = Convert.ToInt32(cislo2);

if (a > b)
{
    Console.WriteLine(cislo);
    Console.WriteLine(cislo2);
}
else if (a > b)
{
    Console.WriteLine(cislo2);
    Console.WriteLine(cislo);
}
else if (a == b)
{
    Console.WriteLine("Čísla jsou shodná");
}
    
    

