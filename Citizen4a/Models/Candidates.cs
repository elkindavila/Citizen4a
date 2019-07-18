using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Candidates
    {
        public Candidates()
        {
            Citizen4 = new HashSet<Citizen4>();
            MsgCitizen4Candidates = new HashSet<MsgCitizen4Candidates>();
        }

        public int IdCandidates { get; set; }
        public int IdCard { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public byte[] Image { get; set; }
        public string Description { get; set; }
        public string DescriptionCampaign { get; set; }
        public string LinkCampaign { get; set; }
        public byte[] LogoCampaign { get; set; }
        public int IdTown { get; set; }
        public int IdUsers { get; set; }

        public Town IdTownNavigation { get; set; }
        public Users IdUsersNavigation { get; set; }
        public ICollection<Citizen4> Citizen4 { get; set; }
        public ICollection<MsgCitizen4Candidates> MsgCitizen4Candidates { get; set; }
    }
}
