using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace embeddedxcontrol.Entities
{
    public class ProjectEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectEntity()
        {
            this.Images = new HashSet<ImageEntity>();
            this.Feedbacks = new HashSet<FeedbackEntity>();
            this.ProjectUpdates = new HashSet<ProjectUpdateEntity>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorId { get; set; }
        public string Topic { get; set; }
        public string Summary { get; set; }
        public string FullText { get; set; }
        public bool Published { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateModified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageEntity> Images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FeedbackEntity> Feedbacks { get; set; }
        public virtual UserEntity UserData { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectUpdateEntity> ProjectUpdates { get; set; }
    }
}
