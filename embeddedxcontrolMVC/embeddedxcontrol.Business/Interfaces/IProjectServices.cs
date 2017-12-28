using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface IProjectServices
    {
        ProjectEntity GetProjectById(int projectId);
        IEnumerable<ProjectEntity> GetAllProjects();
        string CreateProject(ProjectEntity projectEntity);
        bool UpdateProject(int projectId, ProjectEntity projectEntity);
        bool DeleteProject(int projectId);
    }
}
