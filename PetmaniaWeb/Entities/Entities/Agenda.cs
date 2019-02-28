using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Agenda
    {
        public long IdAgenda  { get; set; }
        public DateTime Data  { get; set; }
        public long IdCliente { get; set; }
        public long IdAnimal  { get; set; }
        public long IdServico { get; set; }
        public long IdPetShop { get; set; }
    }
}