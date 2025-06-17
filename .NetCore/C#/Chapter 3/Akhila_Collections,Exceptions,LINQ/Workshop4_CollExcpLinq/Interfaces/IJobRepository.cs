using Workshop4_CollExcpLinq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4_CollExcpLinq.Interfaces
{
    public interface IJobRepository
    {
        List<Jobs> GetAllJobs();
    }
}
