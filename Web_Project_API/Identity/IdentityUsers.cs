using Microsoft.AspNetCore.Identity;

namespace Web_Project_API.Identity
{
    public class IdentityUsers:IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int confirmemailcode { get; set; }
        public string ConfirmPassword { get; set; }
        public int UsersInformationId { get; set; }
       
    }
}
