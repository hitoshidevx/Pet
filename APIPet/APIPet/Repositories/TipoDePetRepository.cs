using APIPet.Context;
using APIPet.Domains;
using APIPet.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;

namespace APIPet.Repositories
{
    public class TipoDePetRepository : ITipoDePet
    {

        PetShopContext conexao = new PetShopContext();
        SqlCommand cmd         = new SqlCommand();

        public TipoDePet Alterar(int id, TipoDePet tipo)
        {
            cmd.Connection  = conexao.Conectar();
            cmd.CommandText = "UPDATE TipoDePet SET " +
                "Descricao = @descricao WHERE IdTipoDePet = @id";

            cmd.Parameters.AddWithValue("@id", id);

            cmd.Parameters.AddWithValue("@descricao", tipo.Descricao);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
            return tipo;
        }

        public TipoDePet BuscarPorID(int id)
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "SELECT * FROM TipoDePet WHERE IdTipoDePet = @id";

            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dados = cmd.ExecuteReader();

            TipoDePet tipo = new TipoDePet();

            while(dados.Read())
            {
                tipo.IdTipoDePet = Convert.ToInt32(dados.GetValue(0));
                tipo.Descricao = dados.GetValue(1).ToString();
            }

            conexao.Desconectar();
            return tipo;
        }

        public TipoDePet Cadastrar(TipoDePet tipo)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "INSERT INTO TipoDePet(Descricao)" +
                "VALUES" +
                "(@descricao)";
            cmd.Parameters.AddWithValue("@descricao", tipo.Descricao);

            cmd.ExecuteNonQuery();
            conexao.Desconectar();

            return tipo;
        }

        public void Excluir(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "DELETE FROM TipoDePet WHERE IdTipoDePet = @id";
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public List<TipoDePet> ListarTodos()
        {
            cmd.Connection = conexao.Conectar();
            cmd.CommandText = "SELECT * FROM TipoDePet";

            SqlDataReader dados = cmd.ExecuteReader();

            List<TipoDePet> tpsdepet = new List<TipoDePet>();

            while(dados.Read())
            {

                tpsdepet.Add(
                    new TipoDePet()
                    {
                        IdTipoDePet = Convert.ToInt32(dados.GetValue(0)),
                        Descricao = dados.GetValue(1).ToString()
                    }

                    );

            }

            conexao.Desconectar();
            return tpsdepet;
        }
    }
}
