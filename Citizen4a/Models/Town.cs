using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Town
    {
        public Town()
        {
            Candidates = new HashSet<Candidates>();
            Citizen4 = new HashSet<Citizen4>();
            Sector = new HashSet<Sector>();
        }

        public int IdTown { get; set; }
        public string Name { get; set; }

        public ICollection<Candidates> Candidates { get; set; }
        public ICollection<Citizen4> Citizen4 { get; set; }
        public ICollection<Sector> Sector { get; set; }
    }
}
