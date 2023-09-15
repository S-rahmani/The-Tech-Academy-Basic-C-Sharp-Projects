using System.Data.Entity;

namespace CodeFirstDemo
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}