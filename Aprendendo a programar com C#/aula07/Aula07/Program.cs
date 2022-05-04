using System;
using System.IO;
//biblioteca de referencia para utilizacao do FileStream.

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ler dados de arquivo local.


            //  \ o C# aguarda um comando especial. colocamos um @ para entender que é apenas texto.     


            //caminho do nosso arquivo criado.
            string enderecoArquivo = @"C:\Users\Lucas - Senai\Desktop\AULA07_DADOS\dados.txt";

            //FileStream classe que estamos instanciando,
               //estamos orientando onde esta o arquivo e o que deve ser feito.
            
            //preparacao do arquivo.
            FileStream arquivo = new FileStream(enderecoArquivo, FileMode.Open);

            //classe que vai ler o arquivo preparado (stream)
            StreamReader leitor = new StreamReader(arquivo);

            // While = estrutura de repeticao.
            // leitor.EndOfStream = (BOOL) -  informar que terminou de ler.


            //percorrer o arquivo ate terminar de ler.

            //queremos que fique no while apenas enquanto o EndOfStream for FALSE.
            while (!leitor.EndOfStream)
            {
                string linha = leitor.ReadLine();

                Profissional novoProfissional = ConverterStringParaProfissional(linha);

                // interpolação $ terão codigo C# no meio da string.
                string mensagem = ($"Nome: { novoProfissional.nome }, Idade: { novoProfissional.idade }, Especialidade: { novoProfissional.especialidade }");

                Console.WriteLine(mensagem);
            }

            //liberar o processo do arquivo e de leitura.
            arquivo.Close();
            leitor.Close();

        }


        //vamos criar uma funcao que vai receber um texto e devolver o profissional.

        static Profissional ConverterStringParaProfissional(string linha)
        {
           
            //Lucas 28 Dados

                              //Split responsavel por dividir a string de acordo com o um padrao..
                                // nesse caso é o espaco.
            string[] campos = linha.Split(' ');

            Profissional profissional = new Profissional();
            profissional.nome = campos[0];
            profissional.idade = int.Parse(campos[1]);
            profissional.especialidade = campos[2];

            return profissional;

        }

        class Profissional
        {
            //atralho prop + TAB TAB

            //GET = leitura da propriedade;
            //SET = setar/armazenar um valor para a propriedade;

            public string nome { get; set; }
            public int idade { get; set; }
            public string especialidade { get; set; }

        }




    }
}
