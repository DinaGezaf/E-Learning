using E_Learning_Platform.Models;

namespace E_Learning_Platform.Models
{
    public class App_User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Profile_Picture { get; set; }
        
    }
}
