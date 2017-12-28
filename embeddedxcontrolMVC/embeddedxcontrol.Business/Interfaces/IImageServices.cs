using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using embeddedxcontrol.Entities;

namespace embeddedxcontrol.Business.Interfaces
{
    public interface IImageServices
    {
        ImageEntity GetImageById(int imageId);
        IEnumerable<ImageEntity> GetAllImages();
        int CreateImage(ImageEntity imageEntity);
        bool UpdateImage(int imageId, ImageEntity imageEntity);
        bool DeleteImage(int imageId);
    }
}
