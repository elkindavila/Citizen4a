using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Needs
    {
        public Needs()
        {
            NeedsCitizen4 = new HashSet<NeedsCitizen4>();
        }

        public int IdNeeds { get; set; }
        public string DescriptionNeed { get; set; }

        public ICollection<NeedsCitizen4> NeedsCitizen4 { get; set; }
    }
}
