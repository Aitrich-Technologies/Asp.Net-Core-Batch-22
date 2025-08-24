using WebApplication4_Activity.Model;
using WebApplication4_Activity.Repository;

namespace WebApplication4_Activity.Service
{
    public class StudentService
    {
        private readonly StudentRepository  _studentRepository;
        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository=studentRepository;
        }
        public async Task<IList<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }
        //public async Task<Student> AddStudentAsync()
        //{

        //}
        public async Task<Student> GetStudentByIdAsync(int Id)
        {
            return await _studentRepository.GetStudentByIdAsync(Id);
        }
    }
}
