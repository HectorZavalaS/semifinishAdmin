//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace semifinishAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class siixsem_semi_manu_td
    {
        public int se_id { get; set; }
        public int se_id_model { get; set; }
        public int se_id_manu { get; set; }
        public int se_id_cgs_prg { get; set; }
    
        public virtual siixsem_cgs_programs_t siixsem_cgs_programs_t { get; set; }
        public virtual siixsem_models_t siixsem_models_t { get; set; }
        public virtual siixsem_semifinish_t siixsem_semifinish_t { get; set; }
    }
}
