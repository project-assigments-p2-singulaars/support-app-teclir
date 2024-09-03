using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using support_app.tableJoin;
using SupportApp.Assignment;
using SupportApp;
using SupportApp.Person;

namespace SupportApp.Data;


public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Project.Project> Projects { get; set; }
    public DbSet<Assignment.Assignment> Assignments { get; set; }
    public DbSet<Person.Person> Persons { get; set; }
    public DbSet<Role.Role> Roles { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    

    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<ProjectStructure>()
            .HasKey(item => new { item.ProjectId, item.PersonId, item.RoleId });
        
        modelBuilder.Entity<ProjectStructure>()
            .HasOne(item => item.Project)
            .WithMany(x => x.ProjectStructure)
            .HasForeignKey(x => x.ProjectId);

        modelBuilder.Entity<ProjectStructure>()
            .HasOne(item => item.Person)
            .WithMany(x => x.ProjectStructure)
            .HasForeignKey(x => x.PersonId);

        modelBuilder.Entity<ProjectStructure>()
            .HasOne(item => item.Role)
            .WithMany(x => x.ProjectStructure)
            .HasForeignKey(x => x.RoleId);

        modelBuilder.Entity<Assignment.Assignment>()
            .HasOne(item => item.Project)
            .WithMany(x => x.SupportTask)
            .HasForeignKey(x => x.ProjectId);

        modelBuilder.Entity<Assignment.Assignment>()
            .HasOne(item => item.Person)
            .WithMany(x => x.Assignments)
            .HasForeignKey(x => x.PersonId);

        


    }
    
    }
    