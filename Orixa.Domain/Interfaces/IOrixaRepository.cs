using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orixa.Domain.Models;

namespace Orixa.Domain.Interfaces
{

    public interface IOrixaRepository
    {
        void Criar(Orixa orixa);
        Orixa Ler(int id);
        List<Orixa> LerTodos();
        void Atualizar(Orixa orixa);
        void Deletar(int id);

    }
}
