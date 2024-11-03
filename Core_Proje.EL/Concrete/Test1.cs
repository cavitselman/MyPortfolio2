using System.ComponentModel.DataAnnotations;

namespace Core_Proje.EL.Concrete
{
    public class Test1
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
