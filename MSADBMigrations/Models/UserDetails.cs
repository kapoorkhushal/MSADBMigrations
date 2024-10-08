﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSADBMigrations.Models
{
    [Table("User")]
    public class UserDetails: BaseEntity
    {
        /// <summary>
        /// user id
        /// </summary>
        [Key]
        [Required]
        public Guid UserId { get; set; }

        /// <summary>
        /// location details
        /// </summary>
        [Required]
        public virtual LocationDetails? Location { get; set; }

        /// <summary>
        /// mood frequency
        /// </summary>
        [Required]
        public int Mood {  get; set; }

        /// <summary>
        /// image location in file system
        /// </summary>
        [Required]
        public string? Image { get; set; }
    }
}
