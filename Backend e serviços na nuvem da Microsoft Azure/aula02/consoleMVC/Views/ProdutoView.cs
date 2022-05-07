using consoleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleMVC.Views
{
    internal class ProdutoView
    {
        //como parametro vai receber uma lista de produtos.
        public void Listar(List<Produto> ListaProduto)
        {
            //percorrer cada produto e exibir para o usuario.
            foreach (Produto item in ListaProduto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
            }
        }
    }
}
