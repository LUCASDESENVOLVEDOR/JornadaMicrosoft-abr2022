using System;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array();
            //FOR();
            //DoWhile01();
           // While_Debug();
            //SwitchCase();
        }



        static void Array()
        {

            //Array ("Vetor") é uma sequencia nao ordenada de itens.
            //Todos os itens em um array devem ser do mesmo tipo.

            int[] numeros_loteria = { 4, 8, 15, 16, 23, 42, 108 };

            //indice

            //0 = 4;
            //1 = 8;
            //2 = 15;

            //Console.WriteLine(numeros_loteria[0]);     


            for (int i = 0; i <= numeros_loteria.Length; i++)
            {
                Console.WriteLine(numeros_loteria[i]);
            }


        }

        static void FOR()
        {
            //FOR = ("PARA")

            int i; //contador;

            //i = 1 = inicia em 1;
            // i <= 50 = condicao para quantidade;
            // i++ controle que vai adicionar i + 1 até chegar em 50.

            for (i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void DoWhile01()
        {
            int numero = 1;
            do  //faça.
            {
                Console.WriteLine(numero);
                numero++;
                //mesma coisa:   numero = numero + 1;
            }
            while (numero <= 50); //enquanto.


            //codigo 02
            //int numero;

            do
            {
                Console.WriteLine("Digite um número:");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("O número digitado foi {0}", numero);
            }
            while (numero != 10);

        }


        static void While_Debug()
        {
            //F9 = INDICA ONDE SERA INICIADO O DEBUG.
            //F10 = VAI EXECUTAR LINHA POR LINHA
            //F5 = VAI EXECUTAR ATÉ O FINAL OU ATE O PROX BREAKPOINT.

            //CTRL + SCROLL = AUMENTA/DIMUNUI A FONTE

            Console.WriteLine("Informe um número:");

            int numero, soma;
            numero = int.Parse(Console.ReadLine());

            soma = 0;

            while (numero != 0) //enquanto essa condição for VERDADEIRA. (true)
            {
                soma = soma + numero;
                Console.WriteLine("Informe um número:");
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("A soma dos números exibidos {0}", soma);
            Console.ReadKey(); //esperar ENTER para sair.





        }


        static void SwitchCase()
        {
            Console.WriteLine("São Paulo/SP a Belo Horizonte/MG");
            Console.WriteLine("Escolha o transporte: [a]=Avião | [c]=Carro | [o]Ônibus");

            char escolha;
            int tempo;


            //string para char. 
            //ToLower()= converte a String para minusculo.
            //ToUpper() = converte a String para maiusculo.
            escolha = char.Parse(Console.ReadLine().ToLower());

            switch (escolha)
            {
                case 'a': //caso o valor de escolha for a.
                    tempo = 50;
                    break; //sempre que adicionarmos as instrucoes emos que informar que acabou.
                           //Break (parar)

                case 'c': tempo = 480; break;

                case 'o': tempo = 660; break;

                default: tempo = -1; break;
            }

            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponível.");
            }
            else
            {
                Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos.", tempo);
            }



        }



    }
}
