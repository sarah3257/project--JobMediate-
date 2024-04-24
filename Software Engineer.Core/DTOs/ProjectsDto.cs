using Software_Engineer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Engineer.Core.DTOs
{
    public class ProjectsDto
    {
        public int Id { get; set; }
        public string? NameProject { get; set; }
        public DateTime? CreationDate { get; set; }
        public int AchievementId { get; set; }
    }
}
