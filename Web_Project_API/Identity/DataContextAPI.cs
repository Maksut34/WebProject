using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Web_Project_API.Identity
{
    public class DataContextAPI:IdentityDbContext<IdentityUsers, IdentityUsersRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=Maksut12345\SQLEXPRESS02; Database=Web_Project; Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}
