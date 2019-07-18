using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Sector
    {
        public int IdSector { get; set; }
        public string NameSector { get; set; }
        public int IdTown { get; set; }

        public Town IdTownNavigation { get; set; }
    }
}
