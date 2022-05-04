using System;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Representação do mundo real.

            //CLASSE / OBJETO = Físico / Abstrato
            // POO = PROGRAMAÇÃO ORIENTADA A OBJETO

            //Uma classe possui:

            // propriedade (atributos) / caracteristicas;
            // métodos (funções)
            // eventos ( o que é feito durante uma ação)

            // POO = PROGRAMAÇÃO ORIENTADA A OBJETO

            //4 PILARES DE OO;

            //ENCAPSULAMENTO, ABSTRAÇÃO, HERANÇA E POLIMORFISMO.

            // 1º - PILAR ENCAPSULAMENTO
            //AGRUPAR O QUE FAZ SENTIDO ESTAR JUNTO.

            //2º - PILAR ABSTRAÇÃO
            // ATO DE ESCONDER OS DETALHES (ESCONDER AS METODOS)

            //3º HERANÇA
            //CAPACIDADE DE UM OBJETO HERDAR, PROPRIEDADES.
               //METODOS E EVENTOS DE OUTRO OBJETO.


            //4º POLIMORFISMO - QUANDO UM METODO PODE SER EXECUTADO
               // DE FORMAS DIFERENTES
                       // EX (Classe, animal com o metodo emitir som)


            //colocar um obj na memoria 
             //instanciar uma classe.

            Carro fusca = new Carro();
            fusca.placa = "zzz";
            fusca.chassi = "111";
            fusca.peso = 20;

            fusca.Andar();

            
            Moto suzuki = new Moto();
            suzuki.placa = "aaa";
            suzuki.chassi = "4444";
            suzuki.guidao = "";
            suzuki.Andar();
        }


        //CRIAR UM OBJETO CARRO.

        class Carro
        {
            //Todas as variaveis de uma classe são chamadas de propriedades.

            //niveis de acesso.
             // public = publico
             // private = private

            //se nao colocarmos nada o pradrão é private.

            public string placa;
            public string chassi;
            public string cor;
            public int peso;


            //todas as funções são chamadas de métodos.
            public void Andar()
            {
                ConsultarQuantidadeCombustivel();

            }

            void LigarSeta()
            {


            }

            void ConsultarQuantidadeCombustivel()
            {


            }



        }


        //: Carro moto herda todas as propriedades e metodos
          //publicos do Carro.

        class Moto : Carro 
        {
            public string guidao;



        }




        static void NumeroMaior()
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
