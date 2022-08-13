using ASP_NET_HW_Module_02_part_01.Models.Animals;

namespace ASP_NET_HW_Module_02_part_01.Repositories.Interface
{
    public interface IRepositoryAnimals
    {
        List<Animal> GetAnimals();

        void WritingToFile();
    }
}
