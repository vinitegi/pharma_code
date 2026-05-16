using Dapper;
using ProjetoFinal.Database;
using ProjetoFinal.Entities;
using ProjetoFinal.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoFinal.Repositories
{
    public class RemedioRepository : IRepository<Remedio>
    {
        private readonly Conexao _conexao = new Conexao();

        public void Inserir(Remedio entidade)
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"INSERT INTO remedio
                               (nome, preco, quantidade, validade, categoria_id)
                               VALUES
                               (@Nome, @Preco, @Quantidade, @Validade, @CategoriaId)";

                conn.Execute(sql, entidade);
            }
        }

        public void Editar(Remedio entidade)
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"UPDATE remedio
                               SET nome = @Nome,
                                   preco = @Preco,
                                   quantidade = @Quantidade,
                                   validade = @Validade,
                                   categoria_id = @CategoriaId
                               WHERE id = @Id";

                conn.Execute(sql, entidade);
            }
        }

        public void Deletar(int id)
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"DELETE FROM remedio
                               WHERE id = @Id";

                conn.Execute(sql, new { Id = id });
            }
        }

        public List<Remedio> Listar()
        {
            using (var conn = _conexao.GetConnection())
            {
                string sql = @"SELECT 
                                   r.id AS Id,
                                   r.nome AS Nome,
                                   r.preco AS Preco,
                                   r.quantidade AS Quantidade,
                                   r.validade AS Validade,
                                   r.categoria_id AS CategoriaId,
                                   c.nome AS CategoriaNome
                               FROM remedio r
                               INNER JOIN categoria c ON c.id = r.categoria_id
                               ORDER BY r.id";

                return conn.Query<Remedio>(sql).ToList();
            }
        }
    }
}