using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embeddedxcontrol.Entities
{
    public class FeedbackEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public Nullable<int> AuthorId { get; set; }
        public string UnregisteredName { get; set; }
        public Nullable<int> Reference { get; set; }
        public int ProjectId { get; set; }
        public string Text { get; set; }
        public System.DateTime CreatedDate { get; set; }

        public virtual ProjectEntity Project { get; set; }
        public virtual UserEntity UserData { get; set; }
    }
}
