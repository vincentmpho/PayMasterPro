using System.ComponentModel.DataAnnotations;

namespace PayMasterPro.Models
{
    public class Persons
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int PositionId { get; set; }
        public int SalaryId { get; set; }
    }
}
