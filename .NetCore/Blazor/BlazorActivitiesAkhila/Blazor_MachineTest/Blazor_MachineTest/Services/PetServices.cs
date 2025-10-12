using Blazor_MachineTest.Dto;
using Blazor_MachineTest.Model;
using Blazor_MachineTest.Repository;
using System.Reflection.Metadata.Ecma335;

namespace Blazor_MachineTest.Services
{
    public class PetServices
    {
        private readonly PetRepository _petRepository;
        public PetServices(PetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        public async Task AddPetdetails(Pet newPet)
        {
            await _petRepository.AddPetdetails(newPet);
        }
        public async Task<List<PetDto>> GetAllPetsAsync()
        {
            return await _petRepository.GetAllPetsAsync();
        }
        public async Task removePet(int id)
        {
            _petRepository.removePet(id);
        }
        public async Task<Pet> FindoutPet(int id)
        {
            return await _petRepository.FindoutPet(id);
        }
        public async Task updateDetails(Pet newPet)
        {
            await _petRepository.updateDetails(newPet);
        }
    }
}
