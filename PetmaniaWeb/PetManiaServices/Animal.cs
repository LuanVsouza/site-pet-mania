//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetManiaServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class Animal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Animal()
        {
            this.Agenda = new HashSet<Agenda>();
        }
    
        public int IdAnimal { get; set; }
        public string Nome { get; set; }
        public Nullable<System.DateTime> DataNasc { get; set; }
        public Nullable<int> IdTipoAnimal { get; set; }
        public Nullable<int> IdCliente { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agenda> Agenda { get; set; }
        public virtual TipoAnimal TipoAnimal { get; set; }
    }
}
