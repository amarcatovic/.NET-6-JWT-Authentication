using System.ComponentModel.DataAnnotations;

namespace Authentication.Core.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}
