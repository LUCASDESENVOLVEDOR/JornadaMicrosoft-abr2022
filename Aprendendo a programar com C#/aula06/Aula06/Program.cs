using System;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar um programa para ler 3 números e mostrar para o 
            //usuario qual é o maior número.

            Console.WriteLine("Digite três números: ");

            int n1, n2, n3;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            //F9 = DEBUG; (depuração do codigo)
            //F10 = EXECUTAR LINHA POR LINHA
            //F11 = ENTRA NA FUNÇÃO

            //F5 = EXECUTA ATÉ O FINAL OU ATÉ O PROX BREAKPOINT.

            int resultado = Maior(n1, n2, n3);
          
            Console.WriteLine("Maior = " + resultado);
           
        }

        //vamos criar uma função.

        //static =  vamos iniciar com static seguindo o MAIN
        //(para manter a comunicao)

        //int  = representa a saida da função.
        //Mair = nome da função

        //() parenteses sem nada dentro representa que a funcao
        //nao recebera nenhum parametro para executar.


        //(int n1, int n2, int n3) = são parametros que a funcao ira receber. (tipo e nome da variavel)
        static int Maior(int n1, int n2, int n3)
        {
            int maiorNumero;

            if (n1 > n2 && n1 > n3)
            {
                maiorNumero = n1;
            }
            else if (n2 > n3)
            {
                maiorNumero = n2;
            }
            else
            {
                maiorNumero = n3;
            }

            //vamos informar qual é o retorno da nossa função
            //utilizando a palavra reservada return
            return maiorNumero;
        }
    }
}
