using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSADBMigrations.Models
{
    [Table("Location")]
    public class LocationDetails: BaseEntity
    {
        /// <summary>
        /// location id
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LocationId { get; set; }

        /// <summary>
        /// latitude
        /// </summary>
        [Required]
        public string? Latitude { get; set; }

        /// <summary>
        /// longitude
        /// </summary>
        [Required]
        public string? Longitude { get; set; }
    }
}
