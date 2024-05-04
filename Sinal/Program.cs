int Num;

Console.Write("digite um número..: ");
Num = Convert.ToInt32(Console.ReadLine());

if (Num < 0)
{
    Console.Write("Negativo");
}

else if (Num > 0)
{
    Console.WriteLine("Positivo");
}

else
{
    Console.WriteLine("Zero");
}
