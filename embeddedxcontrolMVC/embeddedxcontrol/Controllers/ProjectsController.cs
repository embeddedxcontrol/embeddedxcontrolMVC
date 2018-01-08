using embeddedxcontrol.Business.Interfaces;
using embeddedxcontrol.Business.Services;
using embeddedxcontrol.Entities;
using embeddedxcontrol.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
//using System.Net.Http;
using System.Web.Mvc;

namespace embeddedxcontrol.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly IProjectServices _projectServices;
        
        #region Public Constructor
        /// <summary>
        /// Public constructor to initialize project service instance
        /// </summary>
        public ProjectsController()
        {
            _projectServices = new ProjectServices();
        }
        #endregion

        public ActionResult Index(string topicFilter)
        {
            IEnumerable<ProjectEntity> projectSummaries;
            //ProjectServices _projectServices = new ProjectServices();
            projectSummaries = _projectServices.GetAllProjects(topicFilter);

            //Map ProjectEntity to ProjectListViewModel       
            List<ProjectListViewModel> plvm = new List<ProjectListViewModel>();
            foreach (ProjectEntity p in projectSummaries)
            {
                //Project list item pli
                ProjectListViewModel pli = new ProjectListViewModel();
                pli.Id = p.Id;
                pli.Title = p.Title;
                pli.Summary = p.Summary ?? "Summary not found";
                pli.Author = p.AuthorId ?? "No author listed";
                pli.Topic = p.Topic ?? "";
                plvm.Add(pli);
            }
            //Write out topics list and pass to page through ViewBag
            var topics = (from data in projectSummaries.AsQueryable() select data.Topic).Distinct().OrderBy(Topic => Topic).ToList();
            ViewBag.Topics = (List<string>)topics;

            return View(plvm);
        }

        public ActionResult Create()
        {
            ProjectEditViewModel viewModel = new ProjectEditViewModel();
            viewModel.DateCreated = DateTime.Now;
            //Return CreateOrEdit view
            return View("CreateOrEdit", viewModel);
        }

        public ActionResult GetProject(string id)
        {
            ProjectEntity fullProject;
            fullProject = _projectServices.GetProjectById(id);

            //Seperate topic tags into list

            return View("ProjectView", fullProject);
        }

        [HttpPost]
        public ActionResult SaveProject(ProjectEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                //Map ProjectEditViewModel to ProjectEntity
                ProjectEntity _project = new ProjectEntity();
                if (String.IsNullOrEmpty(model.Id))
                {

                    _project.DateModified = model.DateCreated;
                    _project.DateCreated = model.DateCreated;
                    _project.Title = model.Title;
                    _project.Published = model.Published;
                    _project.Topic = model.Topic;
                    _project.Summary = model.Summary;
                    _project.Topic = model.Topic;
                    _project.AuthorId = model.UserId;

                }

                ProjectServices _projectService = new ProjectServices();

                string _projectId = _projectService.CreateProject(_project);

            }

            return RedirectToAction("Index");
        }
           
      

    }


}
