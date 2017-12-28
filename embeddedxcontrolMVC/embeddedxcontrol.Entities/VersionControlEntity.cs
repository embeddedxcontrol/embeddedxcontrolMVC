using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embeddedxcontrol.Entities
{
    public class VersionControlEntity
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string VersionReference { get; set; }
        public string Notes { get; set; }
        public System.DateTime Date { get; set; }
    }
}
