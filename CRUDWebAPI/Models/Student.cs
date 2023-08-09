using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDWebAPI.Models
{
     public class Student
     {
          [Key]
          public int StudentId { get; set; }

          [Required]
          [Column(TypeName ="nvarchar(30)")]
          public string Name { get; set; }

          public int ContactNumber { get; set; }
          public int Age { get; set; }

     }
}
