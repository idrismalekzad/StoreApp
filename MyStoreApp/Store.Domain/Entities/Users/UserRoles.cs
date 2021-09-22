using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Store.Domain.Entities.Users
{
    public class UserRoles
    {
        public int Id { get; set; }

        [ForeignKey("Users")]
        public int User_Id { get; set; }
        public User Users { get; set; }

        [ForeignKey("Roles")]
        public int Role_Id { get; set; }
        public User Roles { get; set; }
    }
}
