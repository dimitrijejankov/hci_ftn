//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HCI_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class ResourceLocation
    {
        public long id { get; set; }
        public string species_id { get; set; }
        public string maps_id { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
    
        public virtual Maps Maps { get; set; }
        public virtual Species Species { get; set; }
    }
}
