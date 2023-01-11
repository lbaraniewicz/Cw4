using PrzykladWyklad4.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PrzykladWyklad4.Services
{
    public interface IAnimalsDbService
    {
        int DeleteAnimal(int id);
        IEnumerable<Animal> GetAnimals();
        int InsertAnimal(Animal newAnimal);
        int UpdateAnimal(Animal value, int idAnimal);
    }
}
