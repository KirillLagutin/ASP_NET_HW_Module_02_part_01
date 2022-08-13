using ASP_NET_HW_Module_02_part_01.Models.Figures;
using ASP_NET_HW_Module_02_part_01.Repositories.Interface;

namespace ASP_NET_HW_Module_02_part_01.Repositories
{
    public class RepositoryFigures : IRepositoryFigures
    {
        private readonly IEnumerable<Figure> _figures;

        private List<string> ListName { get; set; } = new List<string>();
        private List<string> ListVisual { get; set; } = new List<string>();

        public RepositoryFigures(IEnumerable<Figure> figures)
        {
            _figures = figures;
        }

        public List<string> GetName()
        {
            foreach (var item in _figures)
            {
                ListName.Add(item.Name);
            }
            return ListName;
        }

        public List<string> GetVisual()
        {
            foreach (var item in _figures)
            {
                ListVisual.Add(item.Visual);
            }
            return ListVisual;
        }
    }
}
