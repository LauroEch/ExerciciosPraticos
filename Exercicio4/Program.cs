namespace Exercicio4
{
    public class Program
    {
        static void Main()
        {
            int quantidadeCaracteres = 0;
            
            Console.Write("Digite um texto: ");
            string texto = Console.ReadLine();

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != ' ')    
                {
                    quantidadeCaracteres++;
                }
            }

            Console.WriteLine($"O texto possui {quantidadeCaracteres} caracteres sem contar os espaços!");

          
        }
    }
}