using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestWaifu.Data.Entities
{
    public class Franchise
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = @"Please input title")]
        [StringLength(256, ErrorMessage = @"Title must be less than 100 characters")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = @"Please input author")]
        [StringLength(100, ErrorMessage = @"Author's name must be less than 100 characters")]
        public string Author { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}