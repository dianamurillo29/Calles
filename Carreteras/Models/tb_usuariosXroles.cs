//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carreteras.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_usuariosXroles
    {
        public string usu_id { get; set; }
        public string rol_id { get; set; }
        public string usurol_usuario_crea { get; set; }
        public Nullable<System.DateTime> usurol_fecha_crea { get; set; }
        public string usurol_usuario_modifica { get; set; }
        public Nullable<System.DateTime> usurol_fecha_modifica { get; set; }
    
        public virtual tb_roles tb_roles { get; set; }
        public virtual tb_usuarios tb_usuarios { get; set; }
        public virtual tb_usuarios tb_usuarios1 { get; set; }
        public virtual tb_usuarios tb_usuarios2 { get; set; }
    }
}
