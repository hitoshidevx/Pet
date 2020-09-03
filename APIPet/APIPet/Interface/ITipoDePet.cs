using APIPet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Interface
{
    interface ITipoDePet
    {

        List<TipoDePet> ListarTodos();
        TipoDePet BuscarPorID(int id);
        TipoDePet Cadastrar(TipoDePet tipo);
        TipoDePet Alterar(int id, TipoDePet tipo);
        void Excluir(int id);


    }
}
