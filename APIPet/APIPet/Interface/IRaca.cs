using APIPet.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPet.Interface
{
    interface IRaca
    {

        List<Raca> ListarTodos();
        Raca BuscarPorID(int id);
        Raca Cadastrar(Raca raca);
        Raca Alterar(int id, Raca raca);
        void Excluir(int id);


    }
}
