using Microsoft.EntityFrameworkCore;

namespace CRUD_EntityFrameworkCore.Models
{
    public class UserDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source=LAPTOP-OPH5U10J\SQLEXPRESS;Initial Catalog=CrudDemo;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
    }
}
