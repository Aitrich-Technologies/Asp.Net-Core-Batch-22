using Microsoft.EntityFrameworkCore;
using WebApplication3_Activity.Models;

namespace WebApplication3_Activity.Repository
{
    public class StudentRepository
    {
        public readonly ApplicationDBContext _context;
        [BindProperty]
        public StudentRepository(ApplicationDBContext context)
        { 
            _context = context;
        }
    }
}
