using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaTecnica.Models
{
    [Table("Users")]
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public string HomeWorld { get; set; }
        public string Gender { get; set; }
        public string Specie { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
    }
}
