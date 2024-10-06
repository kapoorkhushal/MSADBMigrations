namespace MSADBMigrations.Models
{
    public class BaseEntity
    {
        /// <summary>
        /// Id of the Entity
        /// </summary>
        public Guid Id { get; set; }

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
