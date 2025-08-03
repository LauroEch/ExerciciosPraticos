namespace Exercicio2
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = string.Concat(nome," ",sobrenome);

            Console.WriteLine(nomeCompleto);
        }
    }
}
