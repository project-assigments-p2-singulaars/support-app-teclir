using Microsoft.EntityFrameworkCore;

namespace SupportApp.Data;

public class ApplicationDBContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Project.Project> Projects { get; set; }
}