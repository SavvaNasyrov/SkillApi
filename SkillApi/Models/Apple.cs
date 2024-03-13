namespace SkillApi.Models
{
    public class Apple
    {
        public Guid? Id { get; set; }

        public string? OwnerName { get; set; }

        public string? From { get; set; }

        public AppleType? Type { get; set; }
    }
}