using Activity_Razor.Model;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Activity_Razor.Repository
{
    public class StudentRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public StudentRepository(ApplicationDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IList<Student>> GetAllStudentsAsync()
        {
            //var students = _context.Students.ToListAsync();
            //return (IList<Student>)students;
            return await _context.Students.ToListAsync();
        }
        public async Task AddStudentAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
        }
        public async Task<Student> GetStudentByIdAsync(int Id)
        {
            var studntId = await _context.Students.FindAsync(Id);
            return studntId;
            
        }
        public async Task DeleteStudentByIdAsync(int id)
        {
            var studnt =await _context.Students.FindAsync(id);
            if (studnt != null)
            {
                _context.Students.Remove(studnt);
                await _context.SaveChangesAsync();
            }


        }
        public async Task UpdateStudentByIdAsync(int Id,Student GetStudent)
        {
            var currentStudent=await _context.Students.FindAsync(Id);
            if (currentStudent == null) return;
            _context.Entry(currentStudent).State=EntityState.Detached;
           
            var updateStudent=_mapper.Map<Student>(GetStudent);
            updateStudent.Id = Id;
            _context.Students.Attach(updateStudent);
            _context.Entry(updateStudent).State=EntityState.Modified;
            await _context.SaveChangesAsync();

        }
    }
}
