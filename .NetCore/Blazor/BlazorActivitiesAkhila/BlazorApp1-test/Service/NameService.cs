using BlazorApp1_test.Model;
using BlazorApp1_test.Repository;
using BlazorApp1_test.Dto;

namespace BlazorApp1_test.Service
{
    public class NameService
    {
        private readonly NameRepository repository;
        public NameService(NameRepository _repository)
        {
            repository= _repository;
        }
        public List<nameDto> GetNames()
        {
            return repository.GetNames();
        }
        public async Task AddNewName(name newname)
        {
            await repository.AddNewName(newname);
        }

        public void deletenamebyname(string deletenam)
        {
            repository.deletenamebyname(deletenam);
        }
        //public void updatename(name nam)
        //{
        //    repository.updatename(nam);
        //}
    }
}
