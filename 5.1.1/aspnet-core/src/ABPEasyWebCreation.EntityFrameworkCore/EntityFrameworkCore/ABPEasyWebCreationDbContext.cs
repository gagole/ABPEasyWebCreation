using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPEasyWebCreation.Authorization.Roles;
using ABPEasyWebCreation.Authorization.Users;
using ABPEasyWebCreation.MultiTenancy;
using ABPEasyWebCreation.Models.Employee;

namespace ABPEasyWebCreation.EntityFrameworkCore
{
    public class ABPEasyWebCreationDbContext : AbpZeroDbContext<Tenant, Role, User, ABPEasyWebCreationDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Relationship> Relationship { get; set; }
        public ABPEasyWebCreationDbContext(DbContextOptions<ABPEasyWebCreationDbContext> options)
            : base(options)
        {
        }
    }
}
