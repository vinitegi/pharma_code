using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.Interfaces
{
    public interface IRepository<T>
    {
        void Inserir(T entidade);

        void Editar(T entidade);

        void Deletar(int id);

        List<T> Listar();
    }
}
