﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_Library.Exceptions
{
    public class OutOfStockException:Exception
    {
        public OutOfStockException() { }
        public OutOfStockException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
