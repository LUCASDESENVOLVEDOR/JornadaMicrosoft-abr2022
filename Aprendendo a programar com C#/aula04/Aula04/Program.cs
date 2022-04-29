using System;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //F9 = INDICA ONDE SERA INICIADO O DEBUG.
            //F10 = VAI EXECUTAR LINHA POR LINHA
            //F5 = VAI EXECUTAR ATÉ O FINAL OU ATE O PROX BREAKPOINT.

            //CTRL + SCROLL = AUMENTA/DIMUNUI A FONTE

            Console.WriteLine("Informe um número:");

            int numero,soma;
            numero =  int.Parse(Console.ReadLine());

            soma = 0;

            while (numero !=0) //enquanto essa condição for VERDADEIRA. (true)
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
