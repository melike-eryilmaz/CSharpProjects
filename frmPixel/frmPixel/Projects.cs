//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace frmPixel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Projects
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projects()
        {
            this.Personels = new HashSet<Personels>();
        }
    
        public int ProjectId { get; set; }
        public byte DepartmentId { get; set; }
        public int CustomerId { get; set; }
        public string ProjectName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual Customers Customers { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual ProjectDetails ProjectDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personels> Personels { get; set; }
    }
}