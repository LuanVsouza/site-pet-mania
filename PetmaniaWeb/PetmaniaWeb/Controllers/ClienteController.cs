using Entities;
using PetManiaServices.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PetManiaWeb.Controllers
{
    public class ClienteController : Controller
    {
        ClienteBusiness clienteBusiness = new ClienteBusiness();

        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }

        //UPDATE
        public ActionResult Edit(long id)
        {
            try
            {
                return View(clienteBusiness.GetCliente(id));
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(500, ex.Message);
            }
        }

        //SAVE
        public ActionResult SaveCliente(ClienteEntity cliente)
        {
            try
            {
                if (cliente.IdCliente == 0)
                {
                    return Json(clienteBusiness.InsertCliente(cliente), JsonRequestBehavior.AllowGet);
                }
                else
                {
                    clienteBusiness.UpdateCliente(cliente);
                    return Json(JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                Response.TrySkipIisCustomErrors = true;
                return Json(ex.Message);
            }
        }

        //DELETE
        public ActionResult DeleteCliente(long id)
        {
            try
            {
                clienteBusiness.DeleteCliente(id);
                return Json(JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                Response.TrySkipIisCustomErrors = true;
                return Json(ex.Message);
            }
        }

        #region
        //GET
        public ActionResult GetCliente()
        {
            var request = HttpContext.Request.Params;
            var draw = Convert.ToInt32(request["draw"]);
            var start = Convert.ToInt32(request["start"]);
            var search = request.Get("search[value]");
            var count = clienteBusiness.GetCount();
            var length = Convert.ToInt32(request["length"]);
            var data = clienteBusiness.GetAllCliente(start, length, search);
            if (search != "")
            {
                count = data.Count;
            }
            return Json(new
            {
                data = data,
                draw = draw,
                iTotalDisplayRecords = count,
                iTotalRecords = length,
            }, JsonRequestBehavior.AllowGet);

        }

        //GETTYPEAHEAD
        public ActionResult GetTypeAhead(string busca)
        {
            return Json(clienteBusiness.GetTypeAhead(busca), JsonRequestBehavior.AllowGet);
        }
        #endregion
    }
}