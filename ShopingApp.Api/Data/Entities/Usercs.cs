using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net;
using ShopingApp.Api.Constants;

namespace ShopingApp.Api.Data.Entities
{
    public class Usercs
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(20)]
        public string Mobile { get; set; }
        public short RoleId { get; set; }

        [Required, MaxLength(25)]
        [Comment("We should not have plain password. Having this just for simplicity and demo purpose")]
        public string Password { get; set; }

        public virtual Role Role { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public static IEnumerable<Usercs> GetInitialUsers() =>
            new List<Usercs>
            {
                new Usercs
                {
                    Id = 1,
                    Name = "Abhay Prince",
                    Email = "abhayprince@outlok.com",
                    Mobile = "1234567890",
                    Password = "123456",
                    RoleId = DatabaseConstants.Roles.Admin.Id
                }
            };

    }

}
