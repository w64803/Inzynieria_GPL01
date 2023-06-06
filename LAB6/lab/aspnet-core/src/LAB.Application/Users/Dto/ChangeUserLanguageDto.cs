using System.ComponentModel.DataAnnotations;

namespace LAB.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}