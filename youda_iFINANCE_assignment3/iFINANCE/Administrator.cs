//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iFINANCE
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administrator
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> dateHired { get; set; }
        public Nullable<System.DateTime> dateFinished { get; set; }
    
        public virtual UserPassword UserPassword { get; set; }
    }
}