using System;

namespace Exercicio5
{
    public class VerificaoPlaca
    {
        string placaVeiculo;
        
        public bool verificacaoTotal()
        {
            return verificacaoCaracteresAlfa() && verificacaoPrimeirosCaracteres() && verificacaoUltimosCaracteres();
        }
        
        public bool verificacaoUltimosCaracteres()
        {
            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(placaVeiculo[i]))
                {
                    return false;
                }
            }
            return true;
        }
        
        public bool verificacaoPrimeirosCaracteres()
        {
            for(int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placaVeiculo[i]))
                {
                    return false;
                }  
            }
            return true;
        }
        
        public bool verificacaoCaracteresAlfa()
        {
            return placaVeiculo.Length == 7;
        }
        public void inserirPlacaVeiculo()
        {
            Console.Write("Digite a placa do veiculo: ");
            placaVeiculo = Console.ReadLine();
        }
    }
}
