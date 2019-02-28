using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities
{
    public class ClienteEntity
    {
        public long IdCliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNasc { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Login { get; set; }
    }
}