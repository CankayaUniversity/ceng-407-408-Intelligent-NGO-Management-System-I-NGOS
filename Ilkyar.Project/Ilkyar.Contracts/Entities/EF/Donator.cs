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
    
    public partial class Donator : ModelBase
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donator()
        {
            this.Donation = new HashSet<Donation>();
            this.DonationRecord = new HashSet<DonationRecord>();
            this.ScholarshipHolder = new HashSet<ScholarshipHolder>();
        }
    
        public long Id { get; set; }
        public long UserId { get; set; }
        public int OccupationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public string WorkPlace { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Donation> Donation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonationRecord> DonationRecord { get; set; }
        public virtual Occupation Occupation { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScholarshipHolder> ScholarshipHolder { get; set; }
    }
}
