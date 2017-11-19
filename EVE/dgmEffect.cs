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
    
    public partial class dgmEffect
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dgmEffect()
        {
            this.dgmTypeEffects = new HashSet<dgmTypeEffect>();
            this.dgmEffectsModifierInfoes = new HashSet<dgmEffectsModifierInfo>();
        }
    
        public short effectID { get; set; }
        public string effectName { get; set; }
        public Nullable<short> effectCategory { get; set; }
        public Nullable<int> preExpression { get; set; }
        public Nullable<int> postExpression { get; set; }
        public string description { get; set; }
        public string guid { get; set; }
        public Nullable<int> iconID { get; set; }
        public Nullable<bool> isOffensive { get; set; }
        public Nullable<bool> isAssistance { get; set; }
        public Nullable<short> durationAttributeID { get; set; }
        public Nullable<short> trackingSpeedAttributeID { get; set; }
        public Nullable<short> dischargeAttributeID { get; set; }
        public Nullable<short> rangeAttributeID { get; set; }
        public Nullable<short> falloffAttributeID { get; set; }
        public Nullable<bool> disallowAutoRepeat { get; set; }
        public Nullable<bool> published { get; set; }
        public string displayName { get; set; }
        public Nullable<bool> isWarpSafe { get; set; }
        public Nullable<bool> rangeChance { get; set; }
        public Nullable<bool> electronicChance { get; set; }
        public Nullable<bool> propulsionChance { get; set; }
        public Nullable<byte> distribution { get; set; }
        public string sfxName { get; set; }
        public Nullable<short> npcUsageChanceAttributeID { get; set; }
        public Nullable<short> npcActivationChanceAttributeID { get; set; }
        public Nullable<short> fittingUsageChanceAttributeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dgmTypeEffect> dgmTypeEffects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dgmEffectsModifierInfo> dgmEffectsModifierInfoes { get; set; }
    }
}