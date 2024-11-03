using System.ComponentModel.DataAnnotations;

namespace Core_Proje.EL.Concrete
{
    public class ToDoList
    {
        [Key]
        public int ID { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
    }
}
