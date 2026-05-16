using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entities
{
    public class Remedio
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }

        public DateTime Validade { get; set; }

        public int CategoriaId { get; set; }

        public int FornecedorId { get; set; }

        public List<Movimentacao> Movimentacoes { get; set; }
    }
}
