using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public string? Phone_num {  get; set; }
    }
}
