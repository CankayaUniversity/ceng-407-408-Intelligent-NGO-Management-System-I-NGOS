//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ilkyar.Contracts.Entities.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Volunteer : ModelBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Volunteer()
        {
            this.BadgeVolunteer = new HashSet<BadgeVolunteer>();
            this.InterestVolunteer = new HashSet<InterestVolunteer>();
            this.ProjectDetailActivity = new HashSet<ProjectDetailActivity>();
            this.VolunteerVote = new HashSet<VolunteerVote>();
        }
    
        public long Id { get; set; }
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsStudent { get; set; }
        public Nullable<int> OccupationId { get; set; }
        public Nullable<int> UniversityId { get; set; }
        public Nullable<long> DepartmentId { get; set; }
        public string Class { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BadgeVolunteer> BadgeVolunteer { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InterestVolunteer> InterestVolunteer { get; set; }
        public virtual Occupation Occupation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectDetailActivity> ProjectDetailActivity { get; set; }
        public virtual University University { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolunteerVote> VolunteerVote { get; set; }
    }
}
