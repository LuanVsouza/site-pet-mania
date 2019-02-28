using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities.Entities
{
    public class Usuario
    {
        public long IdUsuario      { get; set; }
        public string Login        { get; set; }
        public string Senha        { get; set; }
        public long IdPetShop      { get; set; }
        public long IdGrupoUsuario { get; set; }
    }
}