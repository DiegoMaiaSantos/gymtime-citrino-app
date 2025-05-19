using System.ComponentModel.DataAnnotations;

namespace gymtime_citrino_app.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
