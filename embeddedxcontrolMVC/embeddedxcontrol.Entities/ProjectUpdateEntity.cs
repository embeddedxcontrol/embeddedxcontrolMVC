using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embeddedxcontrol.Entities
{
    public class ProjectUpdateEntity
    {
        public int Id { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public string Title { get; set; }
        public string Update { get; set; }
        public string ProjectLink { get; set; }
        public System.DateTime DateCreated { get; set; }

        //public virtual ProjectSummaryViewModel Project { get; set; }
    }
}
