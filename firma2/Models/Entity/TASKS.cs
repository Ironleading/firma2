//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace firma2.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TASKS
    {
        public int ID { get; set; }
        public Nullable<int> AUTHORIZED { get; set; }
        public Nullable<int> TASKTAKER { get; set; }
        public string EXPLANATION { get; set; }
        public string SITUATION { get; set; }
        public Nullable<System.DateTime> DATE_ { get; set; }
    
        public virtual TBLDEPARTMAN TBLDEPARTMAN { get; set; }
        public virtual TBLDEPARTMAN TBLDEPARTMAN1 { get; set; }
    }
}
