//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zero_Hungerv2.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class asign
    {
        public int id { get; set; }
        public int ord_id { get; set; }
        public int emp_id { get; set; }
        public string status { get; set; }
    
        public virtual order order { get; set; }
        public virtual user user { get; set; }
    }
}
