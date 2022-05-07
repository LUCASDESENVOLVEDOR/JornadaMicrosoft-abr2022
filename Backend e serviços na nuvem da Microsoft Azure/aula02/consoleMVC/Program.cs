using consoleMVC.Controllers;
using consoleMVC.Models;
using System;

namespace consoleMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.ListarProdutos();

        }
    }
}
