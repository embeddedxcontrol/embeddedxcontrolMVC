using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embeddedxcontrol.Entities
{
    public class ImageEntity
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string ImageName { get; set; }
        public string ImageDescription { get; set; }
        public byte[] ImageFile { get; set; }

        public virtual ProjectEntity Project { get; set; }
    }
}
