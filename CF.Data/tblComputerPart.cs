//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CF.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblComputerPart
    {
        public tblComputerPart()
        {
            this.tblConfigureParts = new HashSet<tblConfigurePart>();
        }
    
        public int id { get; set; }
        public string PartName { get; set; }
        public string Description { get; set; }
        public int PartType { get; set; }
        public double Price { get; set; }
    
        public virtual tblComputerPartType tblComputerPartType { get; set; }
        public virtual ICollection<tblConfigurePart> tblConfigureParts { get; set; }
    }
}
