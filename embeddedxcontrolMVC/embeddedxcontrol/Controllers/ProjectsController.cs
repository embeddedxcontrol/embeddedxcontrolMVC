using embeddedxcontrol.Business.Interfaces;
using embeddedxcontrol.Business.Services;
using embeddedxcontrol.Entities;
using embeddedxcontrol.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
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

        public ActionResult Index()
        {
            //IEnumerable<Models.ProjectSummaryViewModel> _projectSummaries;
            //ProjectServices _projectServices = new ProjectServices();
            //_projectSummaries = _projectServices.GetAllProjects();
            
            return View();
        }

        public ActionResult Create()
        {
            ProjectEditViewModel viewModel = new ProjectEditViewModel();
            viewModel.DateCreated = DateTime.Now;
            //Return CreateOrEdit view
            return View("CreateOrEdit", viewModel);
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
                    _project.Topic = "Test";
                    _project.AuthorId = model.UserId;

                }

                ProjectServices _projectService = new ProjectServices();

                string _projectId = _projectService.CreateProject(_project);

            }

            return View("Index");


            //public ActionResult GetAllProjects()
            //{
            //    //var projects = _projectServices.GetAllProjects();
            //    //if (projects != null)
            //    //{
            //    //    return Request.CreateResponse(HttpStatusCode.OK, projects);
            //    //}


            //    return Request.CreateResponse(HttpStatusCode.NotFound, "Projects Not Found");
            //}

            //ProjectEntity GetProjectById(int projectId);
            //IEnumerable<ProjectEntity> GetAllProjects();
            //int CreateProject(ProjectEntity projectEntity);
            //bool UpdateProject(int projectId, ProjectEntity projectEntity);
            //bool DeleteProject(int projectId);
        }

    }


}
