namespace ASP_NET_HW_Module_02_part_01.Models
{
    public class Cat : Animal
    {
        public string title = "Кот";
        public string sound = "Мяукает";

        public Cat()
        {
            Title = title;
            Sound = sound;
        }
    }
}
