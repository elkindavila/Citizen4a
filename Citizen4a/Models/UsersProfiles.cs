using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class UsersProfiles
    {
        public int IdUsersProfiles { get; set; }
        public int IdUsers { get; set; }
        public int IdProfiles { get; set; }

        public Profiles IdProfilesNavigation { get; set; }
        public Users IdUsersNavigation { get; set; }
    }
}
