using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ContactManager.Models;

namespace ContactManager.Data;

public class ApplicationDbContext : IdentityDbContext
{
#pragma warning disable CS8618 
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
#pragma warning restore CS8618
        : base(options)
    {
    }
    public DbSet<Contact> Contact { get; set; }
}
