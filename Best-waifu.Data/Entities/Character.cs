using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestWaifu.Data.Entities
{
    public class Character
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = @"Please input name")]
        [StringLength(100, ErrorMessage = @"Name must be less than 100 characters")]
        public string Name { get; set; }

        public int Age { get; set; }

        [ForeignKey("Franchise")]
        public int FranchiseId { get; set; }

        public DateTime BirthDate { get; set; }

        public string Photo { get; set; }

        public bool Gender { get; set; } // false  - female / true - male

        [Required(AllowEmptyStrings = false, ErrorMessage = @"Please character's bio")]
        [StringLength(1000, ErrorMessage = @"Bio must be less than 1000 characters")]
        public string Bio { get; set; }

        public virtual Franchise Franchise { get; set; }
    }
}