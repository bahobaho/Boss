using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boss.Models
{
    public class ProjectTask
    {
        public int Id { get; set; }

        public int ProjectParticipantId { get; set; }
        public ProjectParticipant ProjectParticipant { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AppointmentTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsConfirmed { get; set; }
    }
}
