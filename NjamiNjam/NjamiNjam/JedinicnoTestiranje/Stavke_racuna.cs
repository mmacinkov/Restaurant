//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JedinicnoTestiranje
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stavke_racuna
    {
        public int vk_racun { get; set; }
        public int vk_artikl { get; set; }
        public int Kolicina { get; set; }
    
        public virtual Artikli Artikli { get; set; }
        public virtual Racun Racun { get; set; }
    }
}
