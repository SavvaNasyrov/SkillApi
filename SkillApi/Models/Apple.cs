using Microsoft.AspNetCore.Mvc.ModelBinding;
using Swashbuckle.AspNetCore.Annotations;

namespace SkillApi.Models
{
    public class Apple
    {
        [BindNever]
        [SwaggerSchema(ReadOnly = true)]
        public Guid? Id { get; set; }

        public string? OwnerName { get; set; }

        public string? From { get; set; }

        public AppleType? Type { get; set; }
    }
}