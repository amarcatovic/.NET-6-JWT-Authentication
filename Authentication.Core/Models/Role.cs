using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Authentication.Core.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<UserRole> UsersRoles { get; set; }

        public Role()
        {
            UsersRoles = new HashSet<UserRole>();
        }
    }
}
