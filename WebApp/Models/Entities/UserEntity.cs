using Microsoft.AspNetCore.Identity;

namespace WebApp.Models.Entities
{
    public class UserEntity: IdentityUser   
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public ICollection<UserAddressEntity> UserAdresses { get; set; } = new HashSet<UserAddressEntity>();


    }
}
