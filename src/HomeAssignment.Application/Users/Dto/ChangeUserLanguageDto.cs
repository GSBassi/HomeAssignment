using System.ComponentModel.DataAnnotations;

namespace HomeAssignment.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}