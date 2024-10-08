namespace MSADBMigrations.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// creation date
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// modified timepstamp of the entity
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}
