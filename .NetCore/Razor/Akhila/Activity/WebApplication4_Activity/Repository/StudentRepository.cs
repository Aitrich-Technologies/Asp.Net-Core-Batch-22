using WebApplication4_Activity.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApplication4_Activity.Repository
{
    public class StudentRepository
    {
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task <IList<Student>> GetAllStudentsAsync()
        {
            //var students = _context.Students.ToListAsync();
            //return (IList<Student>)students;
            return (IList<Student>) _context.Students.ToListAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int Id)
        {
            var StudentId = _context.Students.FindAsync(Id);
            return await StudentId;
        }
    }
}
