using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Users
    {
        public Users()
        {
            UsersProfiles = new HashSet<UsersProfiles>();
        }

        public int IdUsers { get; set; }
        public string LoginUsers { get; set; }
        public string PassUsers { get; set; }

        public Candidates Candidates { get; set; }
        public Citizen4 Citizen4 { get; set; }
        public ICollection<UsersProfiles> UsersProfiles { get; set; }
    }
}
