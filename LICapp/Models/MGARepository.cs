using LICapp.LICDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public class MGARepository : IMGARepository
    {
        private readonly AppDbcontext context;

        public MGARepository(AppDbcontext context)
        {
            this.context = context;
        }
        public MGA Add(MGA MGA)
        {
            context.MGAs.Add(MGA);
            context.SaveChanges();
            return MGA;
        }

        public MGA Delete(int id)
        {
            MGA mga = context.MGAs.Find(id);
            if (mga != null)
            {
                context.MGAs.Remove(mga);
                context.SaveChanges();
            }

            return mga;
        }

        public IEnumerable<MGA> GetAllMGAs()
        {
            return context.MGAs;
        }

        public MGA Getmga(int id)
        {
            return context.MGAs.Find(id);
        }

        public MGA Update(MGA mga)
        {
            var mgaData = context.MGAs.Attach(mga);
            mgaData.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return mga;
        }
    }
}
