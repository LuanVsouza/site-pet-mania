using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class GrupoUsuario
    {
        public long IdGrupoUsuario { get; set; }
        public string Descricao    { get; set; }
        public long Tipo           { get; set; } 
    }
}