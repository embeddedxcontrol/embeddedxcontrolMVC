using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embeddedxcontrol.Entities
{
    public class BioEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Biography { get; set; }
        public byte[] Photo { get; set; }
        public string PhotoName { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual UserEntity UserData { get; set; }
    }
}
