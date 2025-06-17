using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Workshop4_CollExcpLinq.Exceptions
{[Serializable]
    public class UserAlreadyExistsException:Exception
    {
        public UserAlreadyExistsException() { }

        public UserAlreadyExistsException(string email) 
            : base(String.Format("User Already Exist with this email",email)) 
        {
        
        }
    }
}
