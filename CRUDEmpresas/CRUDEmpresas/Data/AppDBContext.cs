using Microsoft.EntityFrameworkCore;
using CRUDEmpresas.Models;

namespace CRUDEmpresas.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<Company> Empresas { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext>options) : base(options)
        {
            //Empresas = new DbSet<Company>();    
        }


    }
}
