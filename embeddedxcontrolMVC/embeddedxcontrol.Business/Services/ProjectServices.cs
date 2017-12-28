using embeddedxcontrol.Business.Interfaces;
using embeddedxcontrol.Entities;
using embeddedxcontrol.Repo;
using embeddedxcontrol.Repo.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace embeddedxcontrol.Business.Services
{
    public class ProjectServices : IProjectServices
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor
        /// </summary>
        public ProjectServices()
        {
            _unitOfWork = new UnitOfWork();
        }

        /// <summary>
        /// Fetches project details by id
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns>Single Project Entity</returns>
        public ProjectEntity GetProjectById(int projectId)
        {
            return null;
        }

        /// <summary>
        /// Fetches all projects
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProjectEntity> GetAllProjects()
        {
            return null;
        }

        /// <summary>
        /// Creates a project
        /// </summary>
        /// <param name="projectEntity"></param>
        /// <returns></returns>
        public string CreateProject(ProjectEntity projectEntity)
        {

            using (var scope = new TransactionScope())
            {
                var project = new AspNetProject
                {
                    Id = System.Guid.NewGuid().ToString(),
                    AuthorId = projectEntity.AuthorId,
                    Title = projectEntity.Title,
                    Published = projectEntity.Published,
                    Topic = projectEntity.Topic,
                    Summary = projectEntity.Summary,
                    FullText = projectEntity.FullText,
                    DateCreated = projectEntity.DateCreated,
                    DateModified = projectEntity.DateModified
                };
                _unitOfWork.ProjectRepository.Insert(project);
                _unitOfWork.Save();
                scope.Complete();
                return project.Id;
            }
        }

        /// <summary>
        /// Updates a project given project key
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectEntity"></param>
        /// <returns></returns>
        public bool UpdateProject(int projectId, ProjectEntity projectEntity)
        {
            //Connection to repository
            return true;
        }

        /// <summary>
        /// Deletes project given project key
        /// </summary>
        /// <param name="projectId"></param>
        /// <returns></returns>
        public bool DeleteProject(int projectId)
        {
            return true;
        }
    }
}
