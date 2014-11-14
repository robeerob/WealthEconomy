namespace BusinessObjects
{
    using BusinessObjects.Attributes;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    [DisplayName("User Role")]
    public class UserRole : IdentityUserRole<int>, IEntity
    {
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }

        [DisplayOnListView(false)]
        [DisplayOnEditView(false)]
        public System.DateTime CreatedOn { get; set; }

        [DisplayOnListView(false)]
        [DisplayOnEditView(false)]
        public System.DateTime ModifiedOn { get; set; }

        [DisplayOnListView(false)]
        [DisplayOnEditView(false)]
        public System.DateTime? DeletedOn { get; set; }

        [Timestamp]
        [DisplayOnListView(false)]
        [DisplayOnEditView(false)]
        public byte[] RowVersion { get; set; }
    }
}