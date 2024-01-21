using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using dbEntity = Project.Models.EntityModels;

namespace Project.DataAccess.DBContext
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public DbSet<dbEntity.Project> Projects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
