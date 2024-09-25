using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orixa.Domain.Models;
using Orixa.Domain.Interfaces;


namespace Orixa.Services.Services
{

    public class OrixaService
    {
        private readonly IOrixaRepository _orixaRepository;


        public OrixaService(IOrixaRepository orixaRepository)
        {
            _orixaRepository = orixaRepository;
        }


        public void AdicionarOrixa(Orixa orixa)
        {
            _orixaRepository.Criar(orixa);
        }
    }
}