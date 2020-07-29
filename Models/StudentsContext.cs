using Microsoft.EntityFrameworkCore;
using MvcDemo.Models;

namespace MvcDemo.Models
{
    public class StudentsContext : DbContext
    {
        public StudentsContext (DbContextOptions<StudentsContext> options)
            : base(options)
        {
        }

        public DbSet<Students> Movie { get; set; }
        
    }
}