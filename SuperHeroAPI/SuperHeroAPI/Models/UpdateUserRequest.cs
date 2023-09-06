using System.ComponentModel.DataAnnotations.Schema;

namespace SuperHeroAPI.Models
{
    public class UpdateUserRequest
    {
        public string name { get; set; }
        public string password { get; set; }
        [ForeignKey("IdentityId")]
        public Guid FavHeroi { get; set; }
    }
}
