using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities.Entities
{
    public class Servico
    {
        public long IdServico   { get; set; }
        public string Descricao { get; set; }
        public long IdPetShop   { get; set; }
    }
}