//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectSem3
{
    using System;
    using System.Collections.Generic;
    
    public partial class SeatNumber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeatNumber()
        {
            this.SeatDetailByFlights = new HashSet<SeatDetailByFlight>();
        }
    
        public int SeatNumberId { get; set; }
        public int SeatNumber1 { get; set; }
        public int SeatClassId { get; set; }
        public int PlaneId { get; set; }
    
        public virtual Plane Plane { get; set; }
        public virtual SeatClass SeatClass { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeatDetailByFlight> SeatDetailByFlights { get; set; }
    }
}
