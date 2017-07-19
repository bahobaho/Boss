using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boss.Models
{
    public class Branch
    {
        public int BranchId { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        int BranchLeaderId { get; set; }
        public ProjectParticipant BranchLeader { get; set; }
    }
}