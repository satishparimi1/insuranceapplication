using LICapp.LICDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public class AdvisorRepository : IAdvisorRepository
    {
        private readonly AppDbcontext context;

        public AdvisorRepository(AppDbcontext context)
        {
            this.context = context;
        }
        public Advisor Add(Advisor advisor)
        {
            context.Advisors.Add(advisor);
            context.SaveChanges();
            return advisor;
        }

        public Advisor Delete(int id)
        {
            Advisor advisor = context.Advisors.Find(id);
            if (advisor != null)
            {
                context.Advisors.Remove(advisor);
                context.SaveChanges();
            }

            return advisor;
        }

        public Advisor GetAdvisor(int id)
        {
            return context.Advisors.Find(id);
        }

        public IEnumerable<Advisor> GetAllAdvisors()
        {
            return context.Advisors;
        }

        public Advisor Update(Advisor advisor)
        {
            var AdvisorData = context.Advisors.Attach(advisor);
            AdvisorData.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return advisor;
        }
    }
}
