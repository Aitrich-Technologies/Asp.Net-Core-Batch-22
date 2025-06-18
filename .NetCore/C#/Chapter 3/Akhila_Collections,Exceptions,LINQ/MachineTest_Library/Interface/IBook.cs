using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest_Library.Interface
{
    public interface IBook
    {
        void AddBooks();
        void RemoveBook();
        void DisplayAllBooks();
        void BorrowBook();
    }
}
