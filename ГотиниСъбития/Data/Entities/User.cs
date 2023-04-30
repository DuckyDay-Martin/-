using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace ГотиниСъбития.Data.Entities
{
    public class User : IdentityUser
    {
        public User()
        {

            //
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public bool IsAdmin { get; set; }
    }
}
