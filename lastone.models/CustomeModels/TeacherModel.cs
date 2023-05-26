using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lastone.models.CustomeModels
{
    public class TeacherModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Geneder { get; set; }
        [Required]
        public string MobileNo { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int City { get; set; }
        [Required]
        public int State { get; set; }
        [Required]
        public int Country { get; set; }
        [Required]
        public List<int> TeacherSubjects { get; set; }
    }
}
