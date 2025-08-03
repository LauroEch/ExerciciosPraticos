using System;
using System.Globalization;

namespace Exercicio6
{
    public class Program
    {
        static void Main()
        {
            int exibicaoData;
            
            Console.WriteLine("Escolha a forma de exibição da data:");
            
            Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
            Console.WriteLine("2 - Apenas a data no formato 01/03/2024.");
            Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
            Console.WriteLine("4 - A data com o mês por extenso.\n\n");
            
            Console.Write("Digite qual das opções: ");
            exibicaoData = int.Parse(Console.ReadLine());

            while (exibicaoData < 1 || exibicaoData > 4)
            {
                Console.WriteLine("\nOpção inválida!");
                Console.Write("Digite qual das opções: ");
                exibicaoData = int.Parse(Console.ReadLine());
            }

            DateTime data = DateTime.Now;

            Console.WriteLine();

            switch (exibicaoData)
            {
                case 1:
                    {
                        Console.Write("Data completa: ");
                        Console.WriteLine(data.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR")));
                        break;
                    }
                case 2:
                    {
                        Console.Write("Apenas a data: ");
                        Console.WriteLine(data.ToString("dd/MM/yyyy"));
                        break;
                    }
                case 3:
                    {
                        Console.Write("Apenas a hora: ");
                        Console.WriteLine(data.ToString("HH:mm"));
                        break;
                    }
                case 4:
                    {
                        Console.Write("Data com mês por extenso: ");
                        Console.WriteLine(data.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                        break;
                    }
            }

            }
        
    }
}