using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Boss.Models
{
    public class ProjectParticipant
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
