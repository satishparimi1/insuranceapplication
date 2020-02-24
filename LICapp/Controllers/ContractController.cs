using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LICapp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LICapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private IContractRepository _IcontractRepository;
        public ContractController(IContractRepository contractRepository)
        {
            this._IcontractRepository = contractRepository;
        }
        // GET: api/Contract
        [HttpGet("[action]")]
        public IEnumerable<Contract> Get()
        {
            return this._IcontractRepository.GetContracts();
        }

        // GET: api/Contract/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Contract> Get(int id)
        {

            return this._IcontractRepository.GetContracts(this._IcontractRepository.GetContract(id));
        }

        // POST: api/Contract
        [HttpPost]
        public void Post([FromBody] Contract value)
        {
        }

        // PUT: api/Contract/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
