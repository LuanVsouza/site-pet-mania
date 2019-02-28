using Entities;
using PetManiaServices.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetManiaServices.Business
{
    public class ClienteBusiness
    {
        ClienteRepository clienteRepository = new ClienteRepository();

        //INSERT
        public ClienteEntity InsertCliente(ClienteEntity cliente)
        {
            using (PetManiaDBEntities db = new PetManiaDBEntities())
            {
                var _CLIENTE = clienteRepository.Insert(db, cliente);
                cliente.IdCliente = _CLIENTE.IdCliente;
                db.SaveChanges();
                return cliente;
            }
        }


        //UPDATE
        public void UpdateCliente(ClienteEntity cliente)
        {
            using (PetManiaDBEntities db = new PetManiaDBEntities())
            {
                clienteRepository.Update(db, cliente);
                db.SaveChanges();
            }
        }

        //DELETE
        public void DeleteCliente(long id)
        {
            using (PetManiaDBEntities db = new PetManiaDBEntities())
            {
                if (id != 0)
                {
                    var cliente = new Cliente();
                    clienteRepository.Delete(db, id);
                    db.SaveChanges();
                }
                else
                {
                    throw new Exception("Não há cliente para ser excluído.");
                }
            }
        }

        #region
        //GET
        public ClienteEntity GetCliente(long id)
        {
            var cliente = new ClienteEntity();
            if (id != 0)
            {
                using (PetManiaDBEntities db = new PetManiaDBEntities())
                {
                    cliente = clienteRepository.Get(db, id);
                }
            }
            return cliente;
        }

        //GETCOUNT
        public int GetCount()
        {
            using (PetManiaDBEntities db = new PetManiaDBEntities())
            {
                return clienteRepository.GetCount(db).Count;
            }
        }

        //GETALL
        public List<ClienteEntity> GetAllCliente(int start, int length, string search)
        {
            using (PetManiaDBEntities db = new PetManiaDBEntities())
            {
                var a = new List<ClienteEntity>();
                if (search == "")
                {
                    a = clienteRepository.GetAll(db, start, length);
                }
                else
                {
                    a = clienteRepository.GetSearch(db, search);
                }
                return a;
            }
        }

        //GETTYPEAHEAD
        public List<ClienteEntity> GetTypeAhead(string busca)
        {
            using (PetManiaDBEntities db = new PetManiaDBEntities())
            {
                return clienteRepository.GetTypeAhead(db, busca);
            }
        }
        #endregion
    }
}