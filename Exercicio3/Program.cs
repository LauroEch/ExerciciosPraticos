using System.Runtime.Serialization;

namespace Exercicio3
{
    public class Program
    {
        static void Main()
        {
            double num1, num2, resultadoSoma, resultadoSubtracao, resultadoDivisao, resultadoMultiplicacao, resultadoMedia;

            Console.Write("Digite um número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Soma: {num1 + num2}");
            Console.WriteLine($"Subtração: {num1 - num2}");
            Console.WriteLine($"Multiplicação: {num1 * num2}");

            if (num2 == 0)
                Console.WriteLine("Não é possivel dividir por 0.");
            else
                Console.WriteLine($"Divisão: {num1 / num2:F2}");

            Console.WriteLine($"Média: {(num1 + num2) / 2:F2}");
            
            
        }
    }
}