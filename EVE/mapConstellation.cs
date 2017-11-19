//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SDEModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class mapConstellation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mapConstellation()
        {
            this.jumpsFrom = new HashSet<mapConstellationJump>();
            this.jumpsTo = new HashSet<mapConstellationJump>();
            this.systemJumpsFrom = new HashSet<mapSolarSystemJump>();
            this.systemJumpsTo = new HashSet<mapSolarSystemJump>();
            this.mapSolarSystems = new HashSet<mapSolarSystem>();
        }
    
        public int constellationID { get; set; }
        public string constellationName { get; set; }
        public Nullable<int> regionID { get; set; }
        public Nullable<float> x { get; set; }
        public Nullable<float> y { get; set; }
        public Nullable<float> z { get; set; }
        public Nullable<float> x_Min { get; set; }
        public Nullable<float> x_Max { get; set; }
        public Nullable<float> y_Min { get; set; }
        public Nullable<float> y_Max { get; set; }
        public Nullable<float> z_Min { get; set; }
        public Nullable<float> z_Max { get; set; }
        public Nullable<float> radius { get; set; }
        public Nullable<int> factionID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mapConstellationJump> jumpsFrom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mapConstellationJump> jumpsTo { get; set; }
        public virtual mapRegion mapRegion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mapSolarSystemJump> systemJumpsFrom { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mapSolarSystemJump> systemJumpsTo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mapSolarSystem> mapSolarSystems { get; set; }
    }
}