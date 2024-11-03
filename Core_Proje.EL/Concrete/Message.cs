using System.ComponentModel.DataAnnotations;

namespace Core_Proje.EL.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
