using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HomeAssignment.Authorization.Roles;
using HomeAssignment.Authorization.Users;
using HomeAssignment.MultiTenancy;
using HomeAssignment.Models;

namespace HomeAssignment.EntityFrameworkCore
{
    public class HomeAssignmentDbContext : AbpZeroDbContext<Tenant, Role, User, HomeAssignmentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<CMSContent> CMSContents { get; set; }
        
        public HomeAssignmentDbContext(DbContextOptions<HomeAssignmentDbContext> options)
            : base(options)
        {
        }
    }
}
