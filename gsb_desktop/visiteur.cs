//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gsb_desktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class visiteur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public visiteur()
        {
            this.travailler = new HashSet<travailler>();
        }
    
        public int id_visiteur { get; set; }
        public Nullable<int> id_laboratoire { get; set; }
        public Nullable<int> id_secteur { get; set; }
        public string nom_visiteur { get; set; }
        public string prenom_visiteur { get; set; }
        public string adresse_visiteur { get; set; }
        public string cp_visiteur { get; set; }
        public string ville_visiteur { get; set; }
        public Nullable<System.DateTime> date_embauche { get; set; }
        public string login_visiteur { get; set; }
        public string pwd_visiteur { get; set; }
        public string type_visiteur { get; set; }
    
        public virtual laboratoire LeLaboratoire { get; set; }
        public virtual secteur LeSecteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<travailler> travailler { get; set; }
    }
}