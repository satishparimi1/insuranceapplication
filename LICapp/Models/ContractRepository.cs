using LICapp.LICDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public class ContractRepository : IContractRepository
    {
        private readonly AppDbcontext context;

        public ContractRepository(AppDbcontext context)
        {
            this.context = context;
        }
        public bool CreateContract(Contract contract)
        {
            var contractExist = context.contracts.Where(x => (x.contractSource == contract.contractSource && x.contractTraget == contract.contractTraget) ||
              (x.contractSource == contract.contractSource && x.contractTraget == contract.contractTraget)).FirstOrDefault();
            if (contractExist == null)
            {
                context.contracts.Add(contract);
                context.SaveChanges();
                return true;
            }

            return false;
        }

        public IEnumerable<Contract> GetContracts(Contract contract)
        {
            var contractData = context.contracts.Where(x => (x.contractSource == contract.contractSource && x.contractTraget == contract.contractTraget)).FirstOrDefault();
            var contractCollection = new List<Contract>();
            contractCollection.Add(contractData);
            if (contractData != null)
            {
                var childContracts = context.contracts.Where(x => x.contractSource == contract.contractTraget);
                contractCollection.AddRange(childContracts);
            }

            return contractCollection;
        }
        public IEnumerable<Contract> GetContracts()
        {
            return context.contracts.ToList();
        }
        public Contract GetContract(int id)
        {
            return context.contracts.Find(id);
        }
    }
}
