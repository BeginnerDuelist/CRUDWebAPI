using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Models
{
     public class CRUDWebAPIDbContext:DbContext
     {
          public CRUDWebAPIDbContext(DbContextOptions option) : base(option) 
          {

          
          }
          public DbSet<Student> Students { get; set; }
     }
}
