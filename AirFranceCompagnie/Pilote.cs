//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirFranceCompagnie
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pilote
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pilote()
        {
            this.Vol = new HashSet<Vol>();
        }
    
        public System.Guid IdPilote { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public System.DateTime DateNaissance { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vol> Vol { get; set; }
    }
}
