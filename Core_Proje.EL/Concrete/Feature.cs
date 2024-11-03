using System.ComponentModel.DataAnnotations;

namespace Core_Proje.EL.Concrete
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }
        public string Header { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
