//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrolment
    {
        public int Enrolment_Id { get; set; }
        public Nullable<int> Employee_Id { get; set; }
        public string Enrolment_Desc { get; set; }
        public string Comments { get; set; }
    
        public virtual tblEmployee tblEmployee { get; set; }
    }
}