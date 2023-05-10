using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Profiling> Profilings { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Account_Role> Account_Roles { get; set; }
        public DbSet<Role> Roles { get; set; }

        //fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //one university has many educations
            modelBuilder.Entity<University>()
                        .HasMany(u => u.Educations)
                        .WithOne(e => e.University)
                        .IsRequired(false)
                        .HasForeignKey(e => e.University_Id)
                        .OnDelete(DeleteBehavior.SetNull);
            
            //one educations has one profiling
            modelBuilder.Entity<Education>()
                        .HasOne(e => e.profiling)
                        .WithOne(p => p.Education)
                         .IsRequired(false)
                        .HasForeignKey<Profiling>(p => p.EducationId)
                          .OnDelete(DeleteBehavior.SetNull);
            //one profilling has one employee
            modelBuilder.Entity<Employee>()
                       .HasOne(e => e.Profiling)
                       .WithOne(p => p.Employee)
                       .IsRequired(false)
                       .HasForeignKey<Profiling>(p => p.EmployeeNIK)
                          .OnDelete(DeleteBehavior.Restrict);
            //one employee has one account
            modelBuilder.Entity<Account>()
                        .HasOne(a => a.Employee)
                        .WithOne(e => e.Account)
                         .IsRequired(false)
                        .HasForeignKey<Account>(a => a.EmployeeNik)
                          .OnDelete(DeleteBehavior.Restrict);

            //one account has many account role
            modelBuilder.Entity<Account>()
                         .HasMany(a => a.account_roles)
                         .WithOne(r => r.Account)
                          .IsRequired(false)
                         .HasForeignKey(r => r.AccountNik)
                           .OnDelete(DeleteBehavior.SetNull);

            //one roles has many account role
            modelBuilder.Entity<Role>()
                      .HasMany(r => r.account_roles)
                      .WithOne(a => a.Role)
                       .IsRequired(false)
                      .HasForeignKey(r => r.RoleId)
                        .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
