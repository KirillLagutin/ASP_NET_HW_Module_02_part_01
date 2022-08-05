namespace ASP_NET_HW_Module_02_part_01.Models
{
    public interface IAnimal
    {
        public string ShowTitle();
        public string ShowSound();
    }

    public class Animal : IAnimal
	{
		public string Title { get; set; }
		public string Sound { get; set; }

		public string ShowTitle()
        {
			return Title;
        }
		public string ShowSound()
        {
			return Sound;
        }
	}
}
