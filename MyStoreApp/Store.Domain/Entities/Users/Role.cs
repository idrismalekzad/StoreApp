using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entities.Users
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<UserRoles> userRoles { get; set; }
    }
}
