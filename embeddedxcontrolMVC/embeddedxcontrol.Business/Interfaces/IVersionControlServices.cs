using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface IVersionControlServices
    {
        VersionControlEntity GetVersionById(int versionId);
        IEnumerable<VersionControlEntity> GetAllVersionNotes();
        int CreateVersion(VersionControlEntity versionEntity);
        bool UpdateVersion(int versionId, VersionControlEntity versionEntity);
        bool DeleteVersion(int versionId);
    }
}
