using Core_Proje.Api.DAL.ApiEntity;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje.Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS; Database = Core_ProjeDB2; Trusted_Connection = SSPI; Encrypt = true; TrustServerCertificate = true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
