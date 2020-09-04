using APIPet.Context;
using APIPet.Domains;
using APIPet.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Repositories
{
    public class RacaRepository : IRaca
    {

        PetShopContext conexao = new PetShopContext();
        SqlCommand cmd = new SqlCommand();

        public Raca Alterar(int id, Raca raca)
        {
            throw new NotImplementedException();
        }

        public Raca BuscarPorID(int id)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "SELECT * FROM Raca WHERE IdRaca = @id";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dados = cmd.ExecuteReader();

            Raca raca = new Raca();

            while (dados.Read())
            {
                raca.IdRaca = Convert.ToInt32(dados.GetValue(0));
                raca.Descricao = dados.GetValue(1).ToString();
                raca.IdTipoDePet = Convert.ToInt32(dados.GetValue(2));
            }

            conexao.Desconectar();
            return raca;
        }

        public Raca Cadastrar(Raca raca)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public List<Raca> ListarTodos()
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "SELECT * FROM Raca";

            SqlDataReader dados = cmd.ExecuteReader();

            List<Raca> raca = new List<Raca>();

            while (dados.Read())
            {

                raca.Add(
                    new Raca()
                    {
                        IdRaca = Convert.ToInt32(dados.GetValue(0)),
                        Descricao = dados.GetValue(1).ToString(),
                        IdTipoDePet = Convert.ToInt32(dados.GetValue(2))
                    }

                    );
            }

            conexao.Desconectar();
            return raca;
        }
    }
}
