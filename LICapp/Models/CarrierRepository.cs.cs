using LICapp.LICDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public class CarrierRepository : ICarrierRepository
    {
        private readonly AppDbcontext context;

        public CarrierRepository(AppDbcontext context)
        {
            this.context = context;
        }


        public Carrier Add(Carrier carrier)
        {
            context.Carriers.Add(carrier);
            context.SaveChanges();
            return carrier;
        }

        public Carrier Delete(int id)
        {
            Carrier carrier = context.Carriers.Find(id);
            if (carrier != null)
            {
                context.Carriers.Remove(carrier);
                context.SaveChanges();
            }

            return carrier;
        }

        public IEnumerable<Carrier> GetAllCarriers()
        {
            return context.Carriers;
        }

        public Carrier GetCarrier(int id)
        {
            return context.Carriers.Find(id);
        }

        public Carrier Update(Carrier carrier)
        {
            var carrierData = context.Carriers.Attach(carrier);
            carrierData.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return carrier;
        }
    }
}
