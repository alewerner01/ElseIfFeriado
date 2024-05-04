int primeironumero, segundonumero;

Console.Write("Digite o primeiro número..: ");
primeironumero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o segundo número..: ");
segundonumero = Convert.ToInt32(Console.ReadLine());

if (primeironumero > segundonumero)
{ 
    Console.Write($"{primeironumero} é o maior numero");
}
else
{ 
    Console.Write($"{segundonumero} é o maior numero");
}