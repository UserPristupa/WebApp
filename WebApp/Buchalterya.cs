//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buchalterya
    {
        public int id_buh { get; set; }
        public Nullable<decimal> summa { get; set; }
        public Nullable<int> id_valyti { get; set; }
        public Nullable<int> id_contragent { get; set; }
        public int prih_rash { get; set; }
        public int id_tip_doc { get; set; }
    
        public virtual Contragenti Contragenti { get; set; }
        public virtual Tip_Documenta Tip_Documenta { get; set; }
        public virtual Valyta Valyta { get; set; }
    }
}
