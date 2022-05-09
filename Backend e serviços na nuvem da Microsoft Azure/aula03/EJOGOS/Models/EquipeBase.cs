using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {
        public void CriarPastaOuArquivo(string caminho)
        {
            // "nome da pasta/nomedoarquivo.csv"
            string pasta = caminho.Split('/')[0];

            //se o diretorio nao existir, criar a pasta.
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if (!File.Exists(caminho))
            {
                File.Create(caminho);
            }
        }
    }
}
