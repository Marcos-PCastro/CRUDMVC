using Microsoft.EntityFrameworkCore;

namespace CRUDMVC.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionario { get; set; }
    }
}
