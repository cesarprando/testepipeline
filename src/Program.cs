using ParOuImpar;

Console.WriteLine("Digite um número:");

var entrada = Console.ReadLine();

if (int.TryParse(entrada, out var numero))
{
    if (CalculadoraDeParOuImpar.IsPar(numero))
    {
        Console.WriteLine($"O número {numero} é par.");
    }
    else
    {
        Console.WriteLine($"O número {numero} é ímpar.");
    }
}
else
{
    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
}