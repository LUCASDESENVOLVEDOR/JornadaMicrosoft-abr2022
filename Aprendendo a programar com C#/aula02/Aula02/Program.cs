using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
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


    }
}
