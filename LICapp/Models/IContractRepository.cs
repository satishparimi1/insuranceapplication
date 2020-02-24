using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public interface IContractRepository
    {
        bool CreateContract(Contract contract);
        IEnumerable<Contract> GetContracts(Contract contract);
        IEnumerable<Contract> GetContracts();
        Contract GetContract(int id);

    }
}
