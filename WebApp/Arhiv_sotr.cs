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
    
    public partial class Arhiv_sotr
    {
        public int id_arh { get; set; }
        public int id_sotr { get; set; }
        public System.DateTime data_uvolneniya { get; set; }
        public string name_sotr { get; set; }
        public string lastname_sotr { get; set; }
        public string adress_sotr { get; set; }
        public string email_sotr { get; set; }
        public string phone_sotr { get; set; }
        public string id_otd { get; set; }
        public System.DateTime data_priema { get; set; }
        public int id_dolzhn { get; set; }
        public int id_prichin { get; set; }
    
        public virtual Prichina Prichina { get; set; }
    }
}
