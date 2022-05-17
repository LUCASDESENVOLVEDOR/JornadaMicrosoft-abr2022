using System;

namespace MenuConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usuario vai informar o que o programa deve fazer.

            //Tera algumas opcoes de escolha.

            bool continuar = true;

            do
            {         

                    Console.WriteLine(@"Escolha uma opção:
                                      1 - Carro
                                      2 - Moto
                                      3 - Caminhão
                                      4 - Cadastrar
                                      5 - Sair
                          ");

                   string OpcaoEscolhida = Console.ReadLine();

                    //Para limpar o console.
                    Console.Clear();

                    switch (OpcaoEscolhida)
                    {

                        case "1": Console.WriteLine("Você escolheu carro."); break;
                        case "2": Console.WriteLine("Você escolheu moto."); break;
                        case "3": Console.WriteLine("Você escolheu caminhão."); break;
                        case "4": Cadastrar(); break;
                        case "5": continuar = false; break;

                        default: Console.WriteLine("Escolha não válida."); break;

                    }

            }

            while (continuar);

        }

        public static void Cadastrar()
        {
            Console.WriteLine("Cadastro realizado");
        }



    }
}
