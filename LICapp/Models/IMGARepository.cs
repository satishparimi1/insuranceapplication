using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.Models
{
    public interface IMGARepository
    {
        MGA Getmga(int id);
        IEnumerable<MGA> GetAllMGAs();
        MGA Add(MGA MGA);
        MGA Update(MGA mga);
        MGA Delete(int id);
    }
}
