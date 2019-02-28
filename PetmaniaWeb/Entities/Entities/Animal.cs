using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class Animal
    {
        public long IdAnimal     { get; set; }
        public string Nome       { get; set; }
        public DateTime DataNasc { get; set; }
        public long IdTipoAnimal { get; set; }
        public long IdCliente    { get; set; }
    }
}