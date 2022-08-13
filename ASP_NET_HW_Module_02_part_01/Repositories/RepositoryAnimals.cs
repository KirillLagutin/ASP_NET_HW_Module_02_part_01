using ASP_NET_HW_Module_02_part_01.Models;
using ASP_NET_HW_Module_02_part_01.Models.Animals;
using ASP_NET_HW_Module_02_part_01.Repositories.Interface;

namespace ASP_NET_HW_Module_02_part_01.Repositories
{
    public class RepositoryAnimals : IRepositoryAnimals
    {
        public readonly List<Animal> Animals;

        public RepositoryAnimals()
        {
            var cat = new Cat();
            var dog = new Dog();
            var mouse = new Mouse();

			Animals = new List<Animal>();

			Animals.Add(cat);
            Animals.Add(dog);
            Animals.Add(mouse);
        }

        public List<Animal> GetAnimals() => Animals;

        public void WritingToFile()
        {
            using FileStream fs = new FileStream(@"~\App_Data\test.txt", FileMode.Create);

            using StreamWriter sw = new StreamWriter(fs);

            var animals = GetAnimals();
            foreach (var animal in animals)
            {
                sw.WriteLine($"{animal.ShowTitle()} - {animal.ShowSound()}");
            }
        }
    }
}
