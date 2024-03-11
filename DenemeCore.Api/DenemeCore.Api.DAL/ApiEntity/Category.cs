using System.ComponentModel.DataAnnotations;

namespace DenemeCore.Api.DenemeCore.Api.DAL.ApiEntity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
