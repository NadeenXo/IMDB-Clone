//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace neveinNadeen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comments
    {
        public int Id { get; set; }
        public string Conntent { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> M_Id { get; set; }
        public Nullable<int> U_Id { get; set; }
    
        public virtual Movies Movies { get; set; }
        public virtual IMDb_User IMDb_User { get; set; }
    }
}
