using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListinhaDeCompras
{
    public class Listagem
    {
        private List<Produto> produtos;

        public Listagem()
        {
            produtos = new List<Produto>();
        }

        public void AddProduto (Produto produto)
        {
            produtos.Add(produto);
        }

        public List<Produto> GetLista()
        {
            return produtos;
        }
    }
}
