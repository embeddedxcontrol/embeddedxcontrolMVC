using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface IProjectUpdate
    {
        ProjectUpdateEntity GetProjectUpdateById(int projectUpdateId);
        IEnumerable<ProjectUpdateEntity> GetAllProjectUpdates();
        int CreateProjectUpdate(ProjectUpdateEntity projectUpdateEntity);
        bool UpdateProjectUpdate(int projectUpdateId, ProjectUpdateEntity projectUpdateEntity);
        bool DeleteProjectUpdate(int projectUpdateId);
    }
}
