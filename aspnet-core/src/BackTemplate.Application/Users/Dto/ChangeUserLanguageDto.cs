using System.ComponentModel.DataAnnotations;

namespace BackTemplate.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}