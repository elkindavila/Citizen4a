using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Profiles
    {
        public Profiles()
        {
            UsersProfiles = new HashSet<UsersProfiles>();
        }

        public int IdProfiles { get; set; }
        public string NameProfile { get; set; }
        public string DescriptionProfile { get; set; }

        public ICollection<UsersProfiles> UsersProfiles { get; set; }
    }
}
