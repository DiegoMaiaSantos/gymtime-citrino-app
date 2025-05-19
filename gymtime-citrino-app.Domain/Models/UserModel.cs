using System.ComponentModel.DataAnnotations;

namespace gymtime_citrino_app.Models
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }

        public string Unit { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; } = false;
    }
}
