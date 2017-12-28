using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface IBioServices
    {
        BioEntity GetBioById(int bioId);
        IEnumerable<BioEntity> GetAllBios();
        int CreateBio(embeddedxcontrol.Entities.BioEntity bioEntity);
        bool UpdateBio(int bioId, BioEntity bioEntity);
        bool DeleteBio(int bioId);
    }
}
