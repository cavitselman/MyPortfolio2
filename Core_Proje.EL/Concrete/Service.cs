using System.ComponentModel.DataAnnotations;

namespace Core_Proje.EL.Concrete
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
