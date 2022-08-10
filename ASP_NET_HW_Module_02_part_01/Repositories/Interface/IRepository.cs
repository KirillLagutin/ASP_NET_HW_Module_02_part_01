using ASP_NET_HW_Module_02_part_01.Models;

namespace ASP_NET_HW_Module_02_part_01.Repositories.Interface
{
    public interface IRepository
    {
        List<Animal> GetAnimals();

        void WritingToFile();
    }
}
