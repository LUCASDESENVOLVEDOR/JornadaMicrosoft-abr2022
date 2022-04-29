using System;
using System.Globalization;

namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Para executar basta retirar o comentario da função desejada.
            //POR EXEMPLO: abaixo vai ser executado apenas Switch.

            Switch();
            //ELSEIF();
            //IFELSE();
            //IF();
            //SaidaDados();
            //Exercicio();
        }

        static void Switch()
        {
            int valor = 1;
            switch (valor)
            {
                case 1:
                    {
                        Console.WriteLine("1");



                    }
                    break;
                case 2: Console.WriteLine("O valor é: 2"); break;
                case 3: Console.WriteLine("O valor é: 3"); break;
                case 4: Console.WriteLine("O valor é: 4"); break;
                case 5: Console.WriteLine("O valor é: 5"); break;
                case 6: Console.WriteLine("O valor é: 6"); break;
                case 7: Console.WriteLine("O valor é: 7"); break;
                default: Console.WriteLine("O valor não foi analisado"); break;
            }



        }


        static void ELSEIF()
        {

            //Estrutura condicional - encadeamentos.

            //Vamos pergutar a hora atual, e dependendo da hora vamos retornar
            // "bom dia, boa tarde ou boa noite";

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) //aqui temos certeza que nao entrou no primeiro IF.
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }



        }

        static void IFELSE()
        {

            //VAMOS CRIAR UM PROGRAMA, ONDE O USUARIO VAI INFORMAR UM NUMERO
            // E VAMOS RETORNAR SE É O NUMERO É PAR OU IMPAR.

            Console.WriteLine("Entre com um número inteiro:");

            //conversao de string para int.
            int numero = int.Parse(Console.ReadLine());

            //se o resto da divisao por 2 for 0 entao o numero é PAR
            //senão o numero é impar.

            //se o resto da divisao por 2 for 0

            //% RESTO DA DIVISAO
            if (numero % 2 == 0)
            {
                Console.WriteLine("O número é PAR!");
            }
            else //senão o numero é impar.
            {
                Console.WriteLine("O número é IMPAR!");
            }


        }
        static void IF()
        {

            //ESTRUTURA CONDICIONAL
            int x = 10;

            Console.WriteLine("Bom dia!");

            //se x é igual a 5;
            if (x == 5) //se for TRUE excuta o codigo.
            {
                Console.WriteLine("Boa tarde");
                Console.WriteLine("Boa noite!");
            }


        }
        static void SaidaDados()
        {

            int idade = 28;
            double saldo = 10.35784;
            string nome = "Maria";

            //Console.WriteLine(nome + " " + saldo + " " + idade);

            //placeholder - lugar para colocar a variavel.

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2} reais",
                nome, idade, saldo);

            //para colocar um maximo de casas decimais.
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais",
               nome, idade, saldo);

            //para trocar para ponto.
            Console.WriteLine(saldo.ToString("F4", CultureInfo.GetCultureInfo("pt-BR")));

            

        }
        static void Exercicio()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            int idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            /*Usando os valores das variáveis, produza a seguinte saída na tela do console:

                Produtos:
                Computador, cujo preço é $ 2100,00
                Mesa de escritório, cujo preço é $ 650,20

                Registro: 30 anos de idade, código 5290 e gênero M

                Medida com oito casas decimais: 53,23456700
                Arredondado (três casas decimais): 53,235

            */


            //C2 => Converte para moeda. R$
            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é {1:C2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preço é {1:C2}", produto2, preco2);
            Console.WriteLine(); //representa um espaco.
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero {2}", idade, codigo, genero);
            Console.WriteLine(); //representa um espaco.
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);

            //EXERCICIO:

            // 1 – Elabore um algoritmo que receba e calcule a idade média de 5 alunos.

        }
    }
}
