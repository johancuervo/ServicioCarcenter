using Microsoft.AspNetCore.Mvc;
using ServicioCar.Models;
using ServicioCar.Models.DB;
using ServicioCar.Models.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ServicioCar.Controllers
{
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<Cliente> Index()
        {


            using (var db = new Models.DB.CarcenterContextDb())
            {
                List<Cliente> lClientes = (from d in db.Clientes
                                                    select new Cliente {
                                                        id = d.Id,
                                                        primerNombre = d.PrimerNombre,
                                                        primerApellido = d.PrimerApellido,
                                                    }).ToList();
                return lClientes;
            }

        }

        public ActionResult Create()
        {

            return View();
        }

        //Registro Cliente
        [HttpPost]
        public MyResponse Create([FromBody]Cliente cliente)
        {
            MyResponse oR = new MyResponse();
            try
            {
                
                if (ModelState.IsValid)
                {
                 
                    using (CarcenterContextDb db=new CarcenterContextDb())
                    {
                        var clientedb = new ClienteDb();
                        clientedb.Id = cliente.id;
                        clientedb.TipoDocumento = cliente.tipoDocumento;
                        clientedb.Documento = cliente.documento;
                        clientedb.PrimerNombre = cliente.primerNombre;
                        clientedb.SegundoNombre = cliente.segundoNombre;
                        clientedb.PrimerApellido = cliente.primerApellido;
                        clientedb.Celular = cliente.celular;
                        clientedb.Direccion = cliente.direccion;
                        clientedb.Correo = cliente.correo;
                        db.Clientes.Add(clientedb);
                        db.SaveChanges();
                        oR.Success = 1;
                    }
                
                }
        
            }
            catch(Exception ex)
            {
                oR.Success = 0;
                oR.Message = ex.Message;
            }
            return oR;
        

        public ActionResult Edit(int Id)
        {
            Cliente cliente = new Cliente();
            using (CarcenterContextDb db = new CarcenterContextDb())
            {
                var clientedb = db.Clientes.Find(Id);
                cliente.id = Id;
                cliente.tipoDocumento = clientedb.TipoDocumento;
                cliente.documento = clientedb.Documento;
                cliente.primerNombre = clientedb.PrimerNombre;
                cliente.segundoNombre = clientedb.SegundoNombre;
                cliente.primerApellido = clientedb.PrimerApellido;
                cliente.segundoApellido = clientedb.SegundoApellido;
                cliente.celular = clientedb.Celular;
                cliente.direccion = clientedb.Direccion;
                cliente.correo= clientedb.Correo;
            }

            return View(cliente);
        }

        [HttpPut("[action]")]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    using (CarcenterContextDb db = new CarcenterContextDb())
                    {
                        var clientedb = db.Clientes.Find(cliente.id);
                        clientedb.Id = cliente.id;
                        clientedb.TipoDocumento = cliente.tipoDocumento;
                        clientedb.Documento = cliente.documento;
                        clientedb.PrimerNombre = cliente.primerNombre;
                        clientedb.SegundoNombre = cliente.segundoNombre;
                        clientedb.PrimerApellido = cliente.primerApellido;
                        clientedb.Celular = cliente.celular;
                        clientedb.Direccion = cliente.direccion;
                        clientedb.Correo = cliente.correo;
                        db.Entry(clientedb).State = (Microsoft.EntityFrameworkCore.EntityState)System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [HttpGet("[action]")]
        public ActionResult Delete(int Id)
        {
            Cliente cliente = new Cliente();
            using (CarcenterContextDb db = new CarcenterContextDb())
            {
                var clientedb = db.Clientes.Find(Id);
                db.Clientes.Remove(clientedb);
                db.SaveChanges();
            }

            return View(cliente);
        }

    }
}
