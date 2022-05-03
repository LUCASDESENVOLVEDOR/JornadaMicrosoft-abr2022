using System;

namespace Aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros_loteria = { 4, 8, 15, 16, 23, 42 };



            foreach (int numero in numeros_loteria)
            {

                //apenas par

                //if(numero % 2 == 0)
                //{
                //    continue;
                //}

                //sair do foreach
                //break;

                Console.WriteLine(numero);

                //pular para o prox.
                //continue;
            }
        }
    }
}
