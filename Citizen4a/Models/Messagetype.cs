using System;
using System.Collections.Generic;

namespace Citizen4a.Models
{
    public partial class Messagetype
    {
        public Messagetype()
        {
            MsgCitizen4Candidates = new HashSet<MsgCitizen4Candidates>();
        }

        public int IdMessageType { get; set; }
        public string DescriptionType { get; set; }

        public ICollection<MsgCitizen4Candidates> MsgCitizen4Candidates { get; set; }
    }
}
