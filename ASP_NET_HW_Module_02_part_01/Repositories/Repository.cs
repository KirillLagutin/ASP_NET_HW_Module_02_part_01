using ASP_NET_HW_Module_02_part_01.Models;
using ASP_NET_HW_Module_02_part_01.Repositories.Interface;

namespace ASP_NET_HW_Module_02_part_01.Repositories
{
    public class Repository : IRepository
    {
        public readonly List<Animal> Animals;

        public Repository()
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
            using FileStream path = new FileStream(@"~/App_Data/Animal.txt", FileMode.Create);

            using StreamWriter writer = new StreamWriter(path);

            foreach (Animal animal in Animals)
            {
                writer.WriteLine($"{animal.ShowTitle()} - {animal.ShowSound}");
            }
        }
    }
}
