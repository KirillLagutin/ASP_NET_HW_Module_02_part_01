namespace ASP_NET_HW_Module_02_part_01.Models
{
    public class Dog : Animal
    {
        public string title = "Пёс";
        public string sound = "Гавкает";

        public Dog()
        {
            Title = title;
            Sound = sound;
        }
    }
}
