using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace embeddedxcontrol.Models
{
    public class ProjectListViewModel
    {
        public string Title { get; set; }

        [Display(Name = "Summary")]
        public IEnumerable<ProjectSummaryViewModel> Projects{ get; set; }



    }
}