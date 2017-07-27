using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boss.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int ProjectTaskId { get; set; }
        public ProjectTask ProjectTask { get; set; }

        public int ProjectParticipantId { get; set; }
        public ProjectParticipant ProjectParticipant { get; set; }

        public string Text { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
