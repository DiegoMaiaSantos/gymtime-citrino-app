namespace gymtime_citrino_app.Models
{
    public class UserModel : BaseModel
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
