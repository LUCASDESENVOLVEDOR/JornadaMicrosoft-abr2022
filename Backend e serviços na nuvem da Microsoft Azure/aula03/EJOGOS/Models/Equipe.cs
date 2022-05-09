using EJOGOS.Interface;
using System.Collections.Generic;

namespace EJOGOS.Models
{

    //: Herança
    //, Interface (contrato da classe)

    public class Equipe : EquipeBase, IEquipe
    {
        public int idEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }

        //variavel de dados.
        private const string caminhobd = "Database/equipe.csv";


        public Equipe()
        {          

            //metodo da classe de herança EquipeBase.
            CriarPastaOuArquivo(caminhobd);
        }


        //criar uma funcao que vai receber o objeto EQUIPE,
         // e vai retornar no formato de csv. (STRING)

        private string Preparar(Equipe e)
        {
            //return e.idEquipe + ";" + e.Nome + ";" + e.Imagem;

             return $"{ e.idEquipe};{e.Nome};{e.Imagem}";

        }





        public void Criar(Equipe novaequipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> LerEquipes()
        {
            throw new System.NotImplementedException();
        }
    }
}
