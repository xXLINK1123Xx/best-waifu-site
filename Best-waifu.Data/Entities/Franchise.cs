using System.Collections.Generic;

namespace BestWaifu.Data.Entities
{
    public class Franchise
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        public virtual ICollection<Character> Characters { get; set; }
    }
}