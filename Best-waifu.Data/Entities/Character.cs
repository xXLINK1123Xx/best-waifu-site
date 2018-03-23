using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Best_waifu.Data.Entities
{
    public class Character
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public string Photo { get; set; }
    }
}