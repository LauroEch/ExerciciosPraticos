﻿using System;

namespace Exercicio5
{
    public class Program
    {
        static void Main()
        {
            
            VerificaoPlaca placa1 = new VerificaoPlaca();

            placa1.inserirPlacaVeiculo();
            
            if (placa1.verificacaoTotal())
            {
                Console.WriteLine("Placa esta correta!");
            }
            else
            {
                Console.WriteLine("Placa esta incorreta!");
            }
        }
    }
}





//1.Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida,
//seguindo o padrão brasileiro válido até 2018:
// -A placa deve ter 7 caracteres alfanuméricos;
//-Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
//-Os quatro últimos caracteres são números;

//Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.