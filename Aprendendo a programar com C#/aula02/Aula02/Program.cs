using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para executar basta retirar o comentario da função desejada.
            //POR EXEMPLO: abaixo vai ser executado apenas EntradaDeDados.

            //OperadorAritimetico();
            //OperadorAtribuicao();
            //OperadorRelacional();
            //OperadorLogico();
            EntradaDeDados();

        }

        static void OperadorAritimetico()
        {

            //primeiro o tipo depois o nome da variavel, depois o valor de atribuicao.

            int primeiro = 1;
            int segundo = 10;
            int terceiro = 20;


            //quando temos um + com string o C# entende que é uma junção.

            //quando temos + com numeros(int) o C# entende que é soma.

            Console.WriteLine("Soma de todos: " + (primeiro + segundo + terceiro));
            Console.WriteLine("Subtração: " + (terceiro - segundo - primeiro));
            Console.WriteLine("Multiplicação: " + (terceiro * segundo * primeiro));
            Console.WriteLine("Divisão: " + (terceiro / segundo));


            //para duplicar uma linha inteira: CTRL + D
        }
        static void OperadorAtribuicao()
        {

            //OPERADOR DE ATRIBUICAO.

            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine("------");

            //primeira opcao para a + 2;
            //a = a + 2;
            //Console.WriteLine(a);

            //segunda opcao para a + 2;
            a += 2;
            Console.WriteLine(a);


            //utilizando atribuicao para string.
            string s = "ABC";
            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("------");

            a *= 3;
            Console.WriteLine(a);

        }
        static void OperadorRelacional()
        {

            //OPERADOR RELACIONAL

            //Tem o efeito de comparar um dado com outro, sempre teremos 2 resultados possiveis. (TRUE OU FALSE) BOLEANO.

            int a = 10;

            bool resposta1 = a < 10; //resposta é uma condição TRUE OU FALSE.
            bool resposta2 = a < 20;
            bool resposta3 = a > 10;
            bool resposta4 = a > 5;

            Console.WriteLine(resposta1);
            Console.WriteLine(resposta2);
            Console.WriteLine(resposta3);
            Console.WriteLine(resposta4);

            bool resposta5 = a <= 10;
            bool resposta6 = a == 10;
            bool resposta7 = a != 10; //se é diferente de 10.

            Console.WriteLine(resposta5);
            Console.WriteLine(resposta6);
            Console.WriteLine(resposta7);


        }
        static void OperadorLogico()
        {

            //analise de falso e verdadadeiro dos lados.


            //&& => espera que as condicoes sejam true, entao se uma condicao for FALSE,
            //ele vai devolvedor FALSE.

            bool resposta1 = 2 > 3 && 4 != 5;

            Console.WriteLine(resposta1);

            //  || OU  = se uma das condicoes for TRUE vai retornar TRUE.

            bool resposta2 = 2 > 3 || 4 != 5;
            Console.WriteLine(resposta2);


            // ! NAO - O SENTIDO TROCA.

            //é falso que 2 é maior que 3 = TRUE
            // 4 != 5 = TRUE

            //true      //true
            bool resposta3 = !(2 > 3) && 4 != 5;
            Console.WriteLine(resposta3);


        }
        static void EntradaDeDados()
        {
            //Entrada de dados.
            Console.WriteLine("Entrada de dados");
            Console.WriteLine("Digite seu nome: ");

            //Console.ReadLine(); //dessa forma o programa vai ler o que foi digitado no teclado
            // e aguardar a tecla ENTER.

            string nome = Console.ReadLine();

            Console.WriteLine("Nome informado: " + nome);


        }


    }
}
