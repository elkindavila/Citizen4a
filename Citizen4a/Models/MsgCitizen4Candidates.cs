using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class MsgCitizen4Candidates
    {
        public int IdMessageCitizen4 { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime? Date { get; set; }
        public byte[] Image { get; set; }
        public string Answer { get; set; }
        public int IdCandidates { get; set; }
        public int IdCitizen4 { get; set; }
        public int IdMessageType { get; set; }

        public Candidates IdCandidatesNavigation { get; set; }
        public Citizen4 IdCitizen4Navigation { get; set; }
        public Messagetype IdMessageTypeNavigation { get; set; }
    }
}
