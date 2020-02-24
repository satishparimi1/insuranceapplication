using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public interface ICarrierRepository
    {
        Carrier GetCarrier(int id);
        IEnumerable<Carrier> GetAllCarriers();
        Carrier Add(Carrier carrier);
        Carrier Update(Carrier carrier);
        Carrier Delete(int id);
    }
}
