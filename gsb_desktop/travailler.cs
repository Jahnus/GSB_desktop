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
    
    public partial class travailler
    {
        public int id_visiteur { get; set; }
        public System.DateTime jjmmaa { get; set; }
        public int id_region { get; set; }
        public string role_visiteur { get; set; }
    
        public virtual visiteur LesVisiteurs { get; set; }
    }
}