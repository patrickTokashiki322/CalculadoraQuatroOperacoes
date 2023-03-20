internal class Program
{
    private static void Main(string[] args)
    {
        int operation;
        int number1;
        int number2;
        int result;

        Console.WriteLine($@"Seja bem vindo a Calculadora com 4 operações.

Primeiro, digite o número correspondente a operação desejada:

Soma = 1
Subtação = 2
Multiplicação = 3
Divisão = 4");

        operation = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Agora digite o primeiro número:");

        number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        Console.WriteLine("Agora digite o segundo número:");

        number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("");

        if (operation == 1)
        {
            result = Calculadora.Operations.Operations.Addition(number1, number2);

            Console.WriteLine($"O resultado da operação é: {result}");
        }

        else if (operation == 2)
        {
            result = Calculadora.Operations.Operations.Subtration(number1, number2);

            Console.WriteLine($"O resultado da operação é: {result}");
        }

        else if (operation == 3)
        {
            result = Calculadora.Operations.Operations.Multiply(number1, number2);

            Console.WriteLine($"O resultado da operação é: {result}");
        }

        else if (operation == 4)
        {
            result = Calculadora.Operations.Operations.Division(number1, number2);

            Console.WriteLine($"O resultado da operação é: {result}");
        } else if (operation >= 5 || operation == 0)
        {
            Console.WriteLine("Operação cancelada.");
        }
    }
}