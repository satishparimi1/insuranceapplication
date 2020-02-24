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
    public class CarrierController : ControllerBase
    {
        private ICarrierRepository _IcarrierRepository;
        public CarrierController(ICarrierRepository carrierRepository)
        {
            this._IcarrierRepository = carrierRepository;
        }

        // GET: api/Carrier
        [HttpGet]
        public IEnumerable<Carrier> Get()
        {
            return this._IcarrierRepository.GetAllCarriers();
        }

        // GET: api/Carrier/5
        [HttpGet("{id}", Name = "GetCarrier")]
        public Carrier Get(int id)
        {
            return this._IcarrierRepository.GetCarrier(id);
        }

        // POST: api/Carrier
        [HttpPost]
        public void Post([FromBody] Carrier carrier)
        {
            this._IcarrierRepository.Add(carrier);
        }

        // PUT: api/Carrier/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Carrier value)
        {
            this._IcarrierRepository.Update(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            this._IcarrierRepository.Delete(id);
        }
    }
}
