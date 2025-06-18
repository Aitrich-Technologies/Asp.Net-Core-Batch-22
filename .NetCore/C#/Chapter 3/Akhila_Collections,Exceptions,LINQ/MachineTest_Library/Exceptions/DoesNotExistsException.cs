using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_Library.Exceptions
{
    public class DoesNotExistsException:Exception
    {
        public DoesNotExistsException() { }
        public DoesNotExistsException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
