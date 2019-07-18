using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class FocusCitizen4
    {
        public int IdFocusCitizen4col { get; set; }
        public int IdFocus { get; set; }
        public int IdCitizen4 { get; set; }

        public Citizen4 IdCitizen4Navigation { get; set; }
        public Focus IdFocusNavigation { get; set; }
    }
}
