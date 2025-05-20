using JobProviderApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobProviderApplication.Interface
{
    public interface IInterviewProvider
    {
        void ScheduleInterview(Interview interview);
        Interview[] GetInterviews();
    }
}
