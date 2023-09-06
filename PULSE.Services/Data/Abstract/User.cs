namespace PULSE.Services.Data
{
    public abstract class User : AuditableEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PasswordHash { get; set; }
        public string? PasswordSalt { get; set; }
        public bool? Status { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
