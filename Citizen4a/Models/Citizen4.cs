using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Citizen4
    {
        public Citizen4()
        {
            FocusCitizen4 = new HashSet<FocusCitizen4>();
            MsgCitizen4Candidates = new HashSet<MsgCitizen4Candidates>();
            NeedsCitizen4 = new HashSet<NeedsCitizen4>();
        }

        public int IdCitizen4 { get; set; }
        public string FullName { get; set; }
        public int? Age { get; set; }
        public string Adress { get; set; }
        public string Gender { get; set; }
        public string CellPhone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string EconomicActivity { get; set; }
        public string EducationLevel { get; set; }
        public sbyte? HeadFamily { get; set; }
        public sbyte? EmployeedNow { get; set; }
        public string WageLevel { get; set; }
        public string Profession { get; set; }
        public string TypeTransportUse { get; set; }
        public sbyte? WorkEast { get; set; }
        public int IdTown { get; set; }
        public int IdUsers { get; set; }
        public int IdCandidates { get; set; }

        public Candidates IdCandidatesNavigation { get; set; }
        public Town IdTownNavigation { get; set; }
        public Users IdUsersNavigation { get; set; }
        public ICollection<FocusCitizen4> FocusCitizen4 { get; set; }
        public ICollection<MsgCitizen4Candidates> MsgCitizen4Candidates { get; set; }
        public ICollection<NeedsCitizen4> NeedsCitizen4 { get; set; }
    }
}
