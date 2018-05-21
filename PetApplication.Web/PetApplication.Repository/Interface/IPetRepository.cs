using PetApplication.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PetApplication.Repository
{
    public interface IPetRepository
    {
      IEnumerable<PetResultViewModel> GetPetNamesAccordingToGender();
    }
}
