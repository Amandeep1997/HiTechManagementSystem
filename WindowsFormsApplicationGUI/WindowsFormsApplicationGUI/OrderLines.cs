//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplicationGUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderLines
    {
        public int OrderLineId { get; set; }
        public int OrderId { get; set; }
        public int Isbn { get; set; }
        public int SoftwareId { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Softwares Softwares { get; set; }
    }
}
