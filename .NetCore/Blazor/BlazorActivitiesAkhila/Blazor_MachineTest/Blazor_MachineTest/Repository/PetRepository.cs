using AutoMapper;
using Blazor_MachineTest.Dto;
using Blazor_MachineTest.Helper;
using Blazor_MachineTest.Model;
using Microsoft.EntityFrameworkCore;


namespace Blazor_MachineTest.Repository
{
    public class PetRepository
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IMapper _mapper;
        public PetRepository(ApplicationDBContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public async Task AddPetdetails(Pet newPet)
        {
            _dbContext.Pets.Add(newPet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<PetDto>> GetAllPetsAsync()
        {
            List<Pet> AllPet = await _dbContext.Pets.ToListAsync();
            return _mapper.Map<List<PetDto>>(AllPet);

        }
        public async Task removePet(int id)
        {
            var findpet = _dbContext.Pets.Find(id);
            if (findpet != null)
            {
                _dbContext.Pets.Remove(findpet);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task<Pet> FindoutPet(int id)
        {
            var editpet = await _dbContext.Pets.FindAsync(id);
            return editpet;
        }
        public async Task updateDetails(Pet newPet)
        {

            _dbContext.Pets.Update(newPet);
            await _dbContext.SaveChangesAsync();
        }
    }
}
