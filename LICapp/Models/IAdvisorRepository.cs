using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public interface IAdvisorRepository
    {
        Advisor GetAdvisor(int id);
        IEnumerable<Advisor> GetAllAdvisors();
        Advisor Add(Advisor advisor);
        Advisor Update(Advisor advisor);
        Advisor Delete(int id);
    }
}
