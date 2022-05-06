﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMVC.Models
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        //const representa um valor unico que
        // nao pode ser alterado
        private const string caminhodobanco = "Database/Produto.csv";

        //csv - Valores separado por virgula.

        //CTRL + K + D = (Identação do codigo)


        //CRIARMOS UM CONSTRTOR  (quando a classe é construida (new()) 
        //esse método sempre sera acionado.


        // ctor TAB TAB 
        public Produto()
        {
            // SPLIT = responsavel por separar uma string.
            // a partir de um parametro. E tem como retorno um array.

            string pasta = caminhodobanco.Split('/')[0];

            //entrar no IF se a pasta nao existir.
            if (!Directory.Exists(pasta))
            {
                //criar uma pasta no nosso projeto.
                Directory.CreateDirectory(pasta);
            }

            //criar o arquivo apenas se nao existir.
            if (!File.Exists(caminhodobanco))
            {
                //criar o arquivo dentro da pasta.
                File.Create(caminhodobanco);
            }

        }
    }
}
