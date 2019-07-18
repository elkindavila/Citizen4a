using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Focus
    {
        public Focus()
        {
            FocusCitizen4 = new HashSet<FocusCitizen4>();
        }

        public int IdFocus { get; set; }
        public string DescriptionFocus { get; set; }

        public ICollection<FocusCitizen4> FocusCitizen4 { get; set; }
    }
}
