using Activity_Razor.Model;
using Activity_Razor.Repository;

namespace Activity_Razor.Service
{
    public class StudentService
    {
        private readonly StudentRepository _studentRepository;
        public StudentService(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<IList<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }
        public async Task AddStudentAsync(Student student)
        {
            await _studentRepository.AddStudentAsync(student);
        }
        public async Task<Student> GetStudentByIdAsync(int Id)
        {
            return await _studentRepository.GetStudentByIdAsync(Id);
        }
        public async Task DeleteStudentByIdAsync(int Id)
        {
            await _studentRepository.DeleteStudentByIdAsync(Id);
        }
        public async Task UpdateStudentByIdAsync(int Id, Student GetStudent)
        {
            await _studentRepository.UpdateStudentByIdAsync(Id, GetStudent);
        }
    }
}
