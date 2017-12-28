using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace embeddedxcontrol.Models
{
    public class ProjectSummaryViewModel
    {

        [Display(Name = "Article Title")]
        public string Title { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Display(Name = "Topics")]
        public string Topic { get; set; }

        [Display(Name = "Author")]
        public string Author{ get; set; }

    }
}