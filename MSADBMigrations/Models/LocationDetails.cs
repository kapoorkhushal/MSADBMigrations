using System.ComponentModel.DataAnnotations;

namespace MSADBMigrations.Models
{
    public class LocationDetails: BaseEntity
    {
        /// <summary>
        /// location id
        /// </summary>
        public Guid LocationId { get; set; }

        /// <summary>
        /// latitude
        /// </summary>
        [Required]
        public string Latitude { get; set; }

        /// <summary>
        /// longitude
        /// </summary>
        [Required]
        public string Longitude { get; set; }
    }
}
