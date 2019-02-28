using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetManiaServices.Repository
{
    public class ClienteRepository
    {
        //INSERT
        public Cliente Insert(PetManiaDBEntities db, ClienteEntity c)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = c.Nome;
            cliente.CPF = c.CPF;
            //cliente.DataNasc = c.DataNasc;
            cliente.Cidade = c.Cidade;
            cliente.CEP = c.CEP;
            cliente.Bairro = c.Bairro;
            cliente.Endereco = c.Endereco;
            cliente.Numero = c.Numero;
            cliente.Telefone = c.Telefone;
            cliente.Celular = c.Celular;
            cliente.Email = c.Email;
            cliente.Login = c.Login;
            cliente.Senha = c.Senha;
            db.Cliente.Add(cliente);
            return cliente;
        }

        //UPDATE
        public void Update(PetManiaDBEntities db, ClienteEntity c)
        {
            var cliente = (from cli in db.Cliente
                            where cli.IdCliente == c.IdCliente
                            select cli).Single();
            cliente.Nome = c.Nome;
            cliente.CPF = c.CPF;
            //cliente.DataNasc = c.DataNasc;
            cliente.Cidade = c.Cidade;
            cliente.CEP = c.CEP;
            cliente.Bairro = c.Bairro;
            cliente.Endereco = c.Endereco;
            cliente.Numero = c.Numero;
            cliente.Telefone = c.Telefone;
            cliente.Celular = c.Celular;
            cliente.Email = c.Email;
            cliente.Login = c.Login;
            cliente.Senha = c.Senha;
        }

        //DELETE
        public void Delete(PetManiaDBEntities db, long id)
        {
            var cliente = (from cli in db.Cliente
                            where cli.IdCliente == id
                            select cli).Single();
            db.Cliente.Remove(cliente);
        }

        #region
        //GET
        public ClienteEntity Get(PetManiaDBEntities db, long id)
        {
            return (from c in db.Cliente
                    where c.IdCliente == id
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        //DataNasc = c.DataNasc,
                        Cidade = c.Cidade,
                        CEP = c.CEP,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Telefone = c.Telefone,
                        Celular = c.Celular,
                        Email = c.Email,
                        Login = c.Login,
                        Senha = c.Senha
                    }).FirstOrDefault();
        }

        //GETTYPEAHEAD
        public List<ClienteEntity> GetTypeAhead(PetManiaDBEntities db, string busca)
        {
            var resultado = (from c in db.Cliente
                             where c.Nome.Contains("" + busca)
                             orderby c.Nome
                             select new ClienteEntity
                             {
                                 IdCliente = c.IdCliente,
                                 Nome = c.Nome
                             }).Skip(0).Take(5).ToList();
            return resultado;
        }

        //GETCOUNT
        public List<ClienteEntity> GetCount(PetManiaDBEntities db)
        {
            return (from c in db.Cliente
                    orderby c.Nome
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        //DataNasc = c.DataNasc,
                        Cidade = c.Cidade,
                        CEP = c.CEP,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Telefone = c.Telefone,
                        Celular = c.Celular,
                        Email = c.Email,
                        Login = c.Login,
                        Senha = c.Senha
                    }).ToList();
        }

        //GETALL
        public List<ClienteEntity> GetAll(PetManiaDBEntities db, int start, int lenght)
        {
            return (from c in db.Cliente
                    orderby c.Nome
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        //DataNasc = c.DataNasc,
                        Cidade = c.Cidade,
                        CEP = c.CEP,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Telefone = c.Telefone,
                        Celular = c.Celular,
                        Email = c.Email,
                        Login = c.Login,
                        Senha = c.Senha
                    }).Skip(start).Take(lenght).ToList();
        }

        //GETSEARCH
        public List<ClienteEntity> GetSearch(PetManiaDBEntities db, string search)
        {
            return (from c in db.Cliente
                    where c.Nome.Contains("" + search)
                    orderby c.Nome
                    select new ClienteEntity
                    {
                        IdCliente = c.IdCliente,
                        Nome = c.Nome,
                        CPF = c.CPF,
                        //DataNasc = c.DataNasc,
                        Cidade = c.Cidade,
                        CEP = c.CEP,
                        Bairro = c.Bairro,
                        Endereco = c.Endereco,
                        Numero = c.Numero,
                        Telefone = c.Telefone,
                        Celular = c.Celular,
                        Email = c.Email,
                        Login = c.Login,
                        Senha = c.Senha
                    }).Skip(0).Take(10).ToList();
        }
        #endregion
    }
}