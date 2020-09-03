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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
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
