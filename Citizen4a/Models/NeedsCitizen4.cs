using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class NeedsCitizen4
    {
        public int IdNeedsCitizen4 { get; set; }
        public int IdCitizen4 { get; set; }
        public int IdNeeds { get; set; }

        public Citizen4 IdCitizen4Navigation { get; set; }
        public Needs IdNeedsNavigation { get; set; }
    }
}
