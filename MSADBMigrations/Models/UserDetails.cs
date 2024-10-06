namespace MSADBMigrations.Models
{
    public class UserDetails: BaseEntity
    {
        /// <summary>
        /// user id
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// location details
        /// </summary>
        public virtual LocationDetails Location { get; set; }

        /// <summary>
        /// mood frequency
        /// </summary>
        public int Mood {  get; set; }
    }
}
