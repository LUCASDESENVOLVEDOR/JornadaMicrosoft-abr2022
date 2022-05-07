using consoleMVC.Models;
using consoleMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMVC.Controllers
{
    internal class ProdutoController
    {
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();
        public void ListarProdutos()
        {

            //aqui chamando a camada de MODEL e armazenamos 
             // todos os produtos do banco de dados.
            List<Produto> produtos = produto.Ler();

            //agora vamos exibir os produtos a partir 
            // da cama VIEW.
            produtoView.Listar(produtos);

            //outra forma
            //produtoView.Listar(produto.Ler());

        }
    }
}
