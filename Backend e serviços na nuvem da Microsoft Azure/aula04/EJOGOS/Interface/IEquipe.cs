using EJOGOS.Models;
using System.Collections.Generic;

namespace EJOGOS.Interface
{
    public interface IEquipe
    {
        //Contrato
        //Representa os métodos que são obrigatoris em
        // em uma classe.

        void Criar(Equipe novaequipe);
        List<Equipe> LerEquipes();


    }
}
