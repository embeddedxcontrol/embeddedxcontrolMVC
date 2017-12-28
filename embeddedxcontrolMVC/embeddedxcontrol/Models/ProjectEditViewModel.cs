using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace embeddedxcontrol.Models
{
    public class ProjectEditViewModel
    {
        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public string Id { get; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        public string UserId { get; }


        [Display(Name = "Article Title")]
        public string Title { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Display(Name = "Topics [Separate with commas, e.g. topic1, topic2]")]
        public string Topic { get; set; }

        [Display(Name = "Main Content")]
        public string FullText { get; set; }

        [Required]
        [Display(Name = "Ready to Publish?")]
        public bool Published{ get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }


        [Display(Name = "Date Last Modified")]
        public DateTime DateModified { get; set; }

        public ProjectEditViewModel()
        {
            //Return UserId
            UserId = HttpContext.Current.User.Identity.GetUserId();
        }

    }
}