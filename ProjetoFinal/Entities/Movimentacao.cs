using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Entities
{
    public class Movimentacao
    {
        public int Id { get; set; }

        public int RemedioId { get; set; }

        public string Tipo { get; set; }

        public int Quantidade { get; set; }

        public DateTime DataMovimentacao { get; set; }
    }
}
