using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HireMeNow.Models;

namespace HireMeNow.Interface
{
    public interface IAppliedJobs
    {
        void addAppliedJobs(int id);
        void getAppliedJobs();
        //void addSavedJobs(Job job);
        //Job[] getSavedJobs();
    }
}
