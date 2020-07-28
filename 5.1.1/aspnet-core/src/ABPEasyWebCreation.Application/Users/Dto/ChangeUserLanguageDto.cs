using System.ComponentModel.DataAnnotations;

namespace ABPEasyWebCreation.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}