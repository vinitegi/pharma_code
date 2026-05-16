using Dapper;
using ProjetoFinal.Database;
using ProjetoFinal.Entities;
using ProjetoFinal.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Repositories
{
    public class CategoriaRepository : IRepository<Categoria>
    {
        private readonly Conexao _conexao = new Conexao();

        public void Inserir(Categoria entidade)
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"INSERT INTO categoria (nome) VALUES (@Nome)";
                conn.Execute(sql, entidade);
            }
        }

        public void Editar(Categoria entidade)
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"UPDATE categoria SET nome = @Nome WHERE id = @Id";
                conn.Execute(sql, entidade);
            }
        }

        public void Deletar(int id)
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"DELETE FROM categoria WHERE id = @Id";
                conn.Execute(sql, new { Id = id });
            }
        }

        public List<Categoria> Listar()
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"SELECT id AS Id, nome AS Nome FROM categoria";
                return conn.Query<Categoria>(sql).ToList();
            }
        }
    }
}