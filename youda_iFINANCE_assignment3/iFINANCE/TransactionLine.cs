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
    
    public partial class TransactionLine
    {
        public int ID { get; set; }
        public double creditedAmount { get; set; }
        public double debitedAmount { get; set; }
        public string comment { get; set; }
    
        public virtual MasterAccount MasterAccounts { get; set; }
        public virtual MasterAccount MasterAccounts1 { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
