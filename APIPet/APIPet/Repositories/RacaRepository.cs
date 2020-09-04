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
            cmd.Connection   = conexao.Conectar();
            cmd.CommandText  = "UPDATE Raca SET " +
                "Descricao   = @descricao, " +
                "IdTipoDePet = @idtipodepet WHERE IdRaca = @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Parameters.AddWithValue("@descricao", raca.Descricao);
            cmd.Parameters.AddWithValue("@idtipodepet", raca.IdTipoDePet);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
            return raca;
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
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "INSERT INTO Raca(Descricao, IdTipoDePet)" +
                "VALUES" +
                "(@descricao, @idtipodepet)";
            cmd.Parameters.AddWithValue("@descricao", raca.Descricao);
            cmd.Parameters.AddWithValue("@idtipodepet", raca.IdTipoDePet);

            cmd.ExecuteNonQuery();
            conexao.Desconectar();

            return raca;
        }

        public void Excluir(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "DELETE FROM Raca WHERE IdRaca = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
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
