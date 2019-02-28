using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Entities.Entities
{
    public class PetShop
    {

        public long IdPetShop  { get; set; }
        public string Nome     { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Endereco { get; set; }
        public string Numero   { get; set; }
        public string Bairro   { get; set; }
        public string Cidade   { get; set; }
        public string Cep      { get; set; }
        public string Telefone { get; set; }
        public string Celular  { get; set; }
        public string Email    { get; set; }
    }
}