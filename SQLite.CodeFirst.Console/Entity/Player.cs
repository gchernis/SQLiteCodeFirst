﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SQLite.CodeFirst.Console.Entity
{
    [Table("TeamPlayer")]
    public class Player : IEntity
    {
        public int Id { get; set; }

        [Index] // Automatically named 'IX_FirstName'
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Index("IX_LN")]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        public virtual Team Team { get; set; }
    }
}