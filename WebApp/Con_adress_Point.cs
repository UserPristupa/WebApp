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
    
    public partial class Con_adress_Point
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Con_adress_Point()
        {
            this.Adress_contragent = new HashSet<Adress_contragent>();
        }
    
        public int id_con_adr_point { get; set; }
        public int id_con_adr_dom { get; set; }
        public string con_name_adsr_point { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Adress_contragent> Adress_contragent { get; set; }
        public virtual Con_Adress_Dom Con_Adress_Dom { get; set; }
    }
}
